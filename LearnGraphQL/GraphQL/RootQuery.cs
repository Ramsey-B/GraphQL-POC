using GraphQL;
using GraphQL.Types;
using LearnGraphQL.Interfaces;
using LearnGraphQL.Order;
using LearnGraphQL.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnGraphQL.GraphQL
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery(IDependencyResolver resolver)
        {
            var fields = new List<FieldType>();
            fields.AddRange(new OrderQuery(resolver.Resolve<IOrderRepository>()).Fields);
            fields.AddRange(new ProductQuery(resolver.Resolve<IProductRepository>()).Fields);
            foreach (var field in fields)
            {
                AddField(field);
            }
        }
    }
}
