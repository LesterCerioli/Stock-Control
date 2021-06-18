using NetDevPack.Data;
using Stock_Control.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control.Domain.Contracts
{
    public interface IProductBrandRepository : IRepository<ProductBrand>
    {
        Task<ProductBrand> GetById(Guid id);
        Task<ProductBrand> GetByName(string name);
        Task<ProductBrand> GetByCreateDate(DateTimeOffset createDate);
        Task<ProductBrand> GetByLastUpdateDate(DateTimeOffset lastUpdatedate);
        Task<IEnumerable<ProductBrand>> GetAll();

        void Add(ProductBrand productBrand);
        void Update(ProductBrand productBrand);
        void Remove(ProductBrand productBrand);
    }
}
