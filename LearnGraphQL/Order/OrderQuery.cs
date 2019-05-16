using GraphQL.Types;
using LearnGraphQL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnGraphQL.Order
{
    public class OrderQuery : ObjectGraphType
    { 
        public OrderQuery(IOrderRepository orderRepository)
        {
            Field<ListGraphType<OrderType>>(
                "orders",
                resolve: context => orderRepository.GetAll()
                );
        }
    }
}
