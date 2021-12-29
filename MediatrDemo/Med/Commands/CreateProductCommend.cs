using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatrDemo.Med.Commands
{
    public class CreateProductCommend: IRequest<Guid>
    {

        public String Name { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }

        public class CreateProductCommandHnadler : IRequestHandler<CreateProductCommend, Guid>
        {
            public Task<Guid> Handle(CreateProductCommend request, CancellationToken cancellationToken)
            {

                return Task.FromResult(Guid.NewGuid());
                // repository aracılığı ile veri veritabanına gönderilir.
            }
        }
    }
}
