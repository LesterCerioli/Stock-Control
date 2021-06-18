using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control.Domain.Entities
{
    public class StorageLocal : Entity, IAggregateRoot
    {
        public StorageLocal(Guid id, string name, bool actived)
        {
            Id = id;
            Name = name;
            Actived = actived;
            LastUpdateDate = DateTime.Now;
        }

        protected StorageLocal() { }
        public string Name { get; private set; }
        public bool Actived { get; private set; }
        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }

        public void Activate()
        {
            Actived = true;
            LastUpdateDate = DateTime.Now;

        }

        public void inactive()
        {
            Actived = false;
            LastUpdateDate = DateTime.Now;
        }
    }
}
