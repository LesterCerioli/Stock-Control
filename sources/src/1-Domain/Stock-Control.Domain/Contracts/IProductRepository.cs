using NetDevPack.Data;
using Stock_Control.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control.Domain.Contracts
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetById(Guid id);
        Task<Product> GetByName(string name);
        Task<Product> GetByCode(string code);
        Task<IEnumerable<Product>> GetAll();

        void Add(Product product);
        void Update(Product product);
        void Remove(Product product);

    }
}
