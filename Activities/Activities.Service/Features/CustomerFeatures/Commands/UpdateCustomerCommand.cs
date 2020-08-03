using MediatR;
using Activities.Domain.Entities;
using Activities.Persistence;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace Activities.Service.Features.CustomerFeatures.Commands
{
    public class UpdateCustomerCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
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
        public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, Guid>
        {
            private readonly IApplicationDbContext _context;
            public UpdateCustomerCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public Task<Guid> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
