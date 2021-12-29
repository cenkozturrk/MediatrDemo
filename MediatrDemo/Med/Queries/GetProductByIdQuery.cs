using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatrDemo.Med.Queries
{
    //bir istek oluşturacak ve veri tabanından herhangir bir şey alacağız.
    public class GetProductByIdQuery: IRequest<GetProductViewModel>
    {
        public Guid Id { get; set; }

    }
}
