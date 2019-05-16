using LearnGraphQL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnGraphQL.Repositories
{
    public class RepositoryFinder : IRepositoryFinder
    {
        public RepositoryFinder(IOrderRepository orderRepository, IProductRepository productRepository)
        {
            OrderRepository = orderRepository;
            ProductRepository = productRepository;
        }

        public IOrderRepository OrderRepository { get; set; }
        public IProductRepository ProductRepository { get; set; }
    }
}
