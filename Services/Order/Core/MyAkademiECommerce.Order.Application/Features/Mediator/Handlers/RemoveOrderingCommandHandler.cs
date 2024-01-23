using MediatR;
using MyAkademiECommerce.Order.Application.Features.Mediator.Commands;
using MyAkademiECommerce.Order.Application.Interfaces;
using MyAkademiECommerce.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAkademiECommerce.Order.Application.Features.Mediator.Handlers
{
    
    public class RemoveOrderingCommandHandler : IRequestHandler<RemoveOrderingCommand>
    {

        private readonly IRepository<Ordering> _repositoy;

        public RemoveOrderingCommandHandler(IRepository<Ordering> repositoy)
        {
            _repositoy = repositoy;
        }

        public async Task Handle(RemoveOrderingCommand request, CancellationToken cancellationToken)
        {
            var value = await _repositoy.GetByIdAsync(request.Id);
            await _repositoy.DeleteAsync(value);
        }
    }
}
