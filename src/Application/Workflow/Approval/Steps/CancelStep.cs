// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using CleanArchitecture.Razor.Application.Settings;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace CleanArchitecture.Razor.Application.Workflow.Approval.Steps
{
    public class CancelStep : StepBodyAsync
    {
        private readonly IApplicationDbContext _context;
        private readonly IMailService _mailService;
        private readonly ILogger<ApprovedStep> _logger;
        public string WorkId { get; set; }
        public string DocumentName { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string To { get; set; }


        public CancelStep(
            IApplicationDbContext context,
            IMailService mailService,
            ILogger<ApprovedStep> logger)
        {
            _context = context;
            _mailService = mailService;
            _logger = logger;
        }
        public override async Task<ExecutionResult> RunAsync(IStepExecutionContext context)
        {
            WorkId = context.Workflow.Id;
            Body = $"Your request document has been cancel! DocumentName:{DocumentName}";
            Subject = $"Your request has been cancelled.";
            var request = new MailRequest();
            request.To = To;
            request.Subject = Subject;
            request.Body = Body;
            await _mailService.SendAsync(request);
            Console.WriteLine($"Send cancel notfication:{Body},Send to {To}");
            _logger.LogInformation($"Send notfication:{Body},Send to {To}");

            var approval = _context.ApprovalDatas.FirstOrDefault(x => x.WorkflowId == WorkId);
            if (approval != null)
            {
                approval.Status = "Finished";
                approval.Outcome = "cancelled";
                approval.ApprovedDateTime = DateTime.Now;
                approval.Comments = "It's timed out,approval has been automatically cancelled ";
                await _context.SaveChangesAsync(default);
            }
            return ExecutionResult.Next();
        }
    }
}
