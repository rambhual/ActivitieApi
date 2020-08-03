using MediatR;
using Activities.Domain.Entities;
using Activities.Persistence;
using System.Threading;
using System.Threading.Tasks;
using System;
using FluentValidation;

namespace Activities.Service.Features.CustomerFeatures.Commands
{
    public class CreateCustomerCommand : IRequest<Guid>
    {
        public string CustomerName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        public class CommandValidator : AbstractValidator<CreateCustomerCommand>
        {
            public CommandValidator()
            {
                RuleFor(x => x.CustomerName).NotEmpty();
            }
        }
        public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Guid>
        {
            private readonly IApplicationDbContext _context;
            public CreateCustomerCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public Task<Guid> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
