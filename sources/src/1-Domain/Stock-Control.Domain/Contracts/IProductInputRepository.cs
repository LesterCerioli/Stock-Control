using NetDevPack.Data;
using Stock_Control.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control.Domain.Contracts
{
    public interface IProductInputRepository : IRepository<ProductInput>
    {
        Task<ProductInput> GetById(Guid id);
        Task<ProductInput> GetByNumber(string number);
        Task<ProductInput> GetByDate(DateTime date);
        Task<IEnumerable<ProductInput>> GetAll();

        void Add(ProductInput productInput);
        void Update(ProductInput productInput);
        void Remove(ProductInput productInput);
    }
}
