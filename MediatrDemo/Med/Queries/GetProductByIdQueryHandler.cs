using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatrDemo.Med.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductViewModel>
    {
        public Task<GetProductViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {

            var vievModel = new GetProductViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Book"
            };

            return Task.FromResult(vievModel);


            //get product from repository

        }

    }
}
