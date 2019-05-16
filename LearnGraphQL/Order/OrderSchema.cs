using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnGraphQL.Order
{
    public class OrderSchema : Schema
    {
        public OrderSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<OrderQuery>();
        }
    }
}
