using NetDevPack.Data;
using Stock_Control.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control.Domain.Contracts
{
    public interface IProviderRepository : IRepository<Provider>
    {
        Task<Provider> GetById(Guid id);
        Task<Provider> GetByCreateDate(DateTimeOffset createDate);
        Task<Provider> GetByLastUpdateDate(DateTimeOffset lastUpdateDate);
        Task<Provider> GetByDocument(string document);
        Task<Provider> GetByEmailExists(string email);
        Task<Provider> GetByFantasyName(string fantasyName);
        Task<Provider> GetBySocialReason(string socialReason);
        Task<IEnumerable<Provider>> GetAll();

        void Add(Provider provider);
        void Update(Provider provider);
        void Remove(Provider provider);
    }
}
