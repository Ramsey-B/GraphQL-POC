using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnGraphQL.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Data.Product> GetAll();
    }
}
