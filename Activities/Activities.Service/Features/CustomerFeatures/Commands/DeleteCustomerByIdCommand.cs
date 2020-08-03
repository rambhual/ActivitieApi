using MediatR;
using Activities.Persistence;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace Activities.Service.Features.CustomerFeatures.Commands
{
    public class DeleteCustomerByIdCommand : IRequest<Guid>
    {
        public int Id { get; set; }
        public class DeleteCustomerByIdCommandHandler : IRequestHandler<DeleteCustomerByIdCommand, Guid>
        {
            private readonly IApplicationDbContext _context;
            public DeleteCustomerByIdCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public Task<Guid> Handle(DeleteCustomerByIdCommand request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
