using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control.Domain.Entities
{
    public class MeasurementUnit : Entity, IAggregateRoot
    {
        public MeasurementUnit(Guid id, string name, string initial, bool actived, DateTime createDate, DateTime lastUpdateDate)
        {
            Id = id;
            Name = name;
            Initial = initial;
            Actived = actived;
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
        }

        
        protected MeasurementUnit() { }
        public string Name { get; private set; }
        public string Initial { get; private set; }
        public bool Actived { get; private set; }
        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }

        public void Activate()
        {
            Actived = true;
            LastUpdateDate = DateTime.Now;

        }

        public void Inactived()
        {
            Actived = false;
            LastUpdateDate = DateTime.Now;

        }
    }
}
