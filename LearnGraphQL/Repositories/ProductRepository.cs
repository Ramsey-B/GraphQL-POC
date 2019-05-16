using LearnGraphQL.Data;
using LearnGraphQL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnGraphQL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Data.Product> GetAll()
        {
            return new List<Data.Product>()
            {
                new Data.Product()
                {
                    Id = 1,
                    Name = "Item1",
                    Description = "A new item",
                    Type = ProductTypeEnum.Food
                },
                new Data.Product()
                {
                    Id = 2,
                    Name = "Item2",
                    Description = "A new item",
                    Type = ProductTypeEnum.Food
                },
                new Data.Product()
                {
                    Id = 3,
                    Name = "Item3",
                    Description = "A new item",
                    Type = ProductTypeEnum.Food
                }
            };
        }
    }
}
