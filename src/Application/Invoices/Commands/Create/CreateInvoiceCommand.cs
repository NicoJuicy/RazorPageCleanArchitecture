﻿using CleanArchitecture.Razor.Application.Invoices.DTOs;

namespace CleanArchitecture.Razor.Application.Invoices.Commands.Create
{
    public class CreateInvoiceCommand: InvoiceDto,IRequest<Result<int>>, IMapFrom<Invoice>
    {
       
    }
    
    public class CreateInvoiceCommandHandler : IRequestHandler<CreateInvoiceCommand, Result<int>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<CreateInvoiceCommand> _localizer;
        public CreateInvoiceCommandHandler(
            IApplicationDbContext context,
            IStringLocalizer<CreateInvoiceCommand> localizer,
            IMapper mapper
            )
        {
            _context = context;
            _localizer = localizer;
            _mapper = mapper;
        }
        public async Task<Result<int>> Handle(CreateInvoiceCommand request, CancellationToken cancellationToken)
        {
           //TODO:Implementing CreateInvoiceCommandHandler method 
           var item = _mapper.Map<Invoice>(request);
           _context.Invoices.Add(item);
           await _context.SaveChangesAsync(cancellationToken);
           return  Result<int>.Success(item.Id);
        }
    }
}
