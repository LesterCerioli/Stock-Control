using NetDevPack.Data;
using Stock_Control.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control.Domain.Contracts
{
    public interface IMeasurementUnitRepository : IRepository<MeasurementUnit>
    {
        Task<MeasurementUnit> GetById(Guid id);
        Task<MeasurementUnit> GetByCreateDate(DateTime createDate);
        Task<MeasurementUnit> GetByLastUpdateDate(DateTime lastUpdateDate);
        Task<MeasurementUnit> GetByName(string name);
        Task<IEnumerable<MeasurementUnit>> GetAll();

        void Add(MeasurementUnit measurementUnit);
        void Update(MeasurementUnit measurementUnit);
        void Remove(MeasurementUnit measurementUnit);
    }
}
