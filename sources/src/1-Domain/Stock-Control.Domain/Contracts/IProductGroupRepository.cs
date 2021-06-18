using NetDevPack.Data;
using Stock_Control.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control.Domain.Contracts
{
    public interface IProductGroupRepository : IRepository<ProductGroup>
    {
        Task<ProductGroup> GetById(Guid id);
        Task<ProductGroup> GetByName(string name);
        Task<ProductGroup> GetByCreateDate(DateTimeOffset createDate);
        Task<ProductGroup> GetByLastUpdateDate(DateTimeOffset lastUpdatedate);
        Task<IEnumerable<ProductGroup>> GetAll();

        void Add(ProductGroup productGroup);
        void Update(ProductGroup productGroup);
        void Remove(ProductGroup productGroup);
    }
}
