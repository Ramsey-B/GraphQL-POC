using LearnGraphQL.Data;
using LearnGraphQL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnGraphQL.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public IEnumerable<Data.Order> GetAll()
        {
            return new List<Data.Order>()
            {
                new Data.Order()
                {
                    Id = "1",
                    Price = 2,
                    Name = "Item"
                }
            };
        }
    }
}
