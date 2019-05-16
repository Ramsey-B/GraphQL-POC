using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnGraphQL.Interfaces
{
    public interface IRepositoryFinder
    {
        IOrderRepository OrderRepository { get; set; }
        IProductRepository ProductRepository { get; set; }
    }
}
