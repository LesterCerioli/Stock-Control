using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control.Domain.Entities
{
    public class City : Entity, IAggregateRoot
    {

        private IList<State> _states;
        public City(Guid id, string name, bool actived)
        {
            Id = id;
            Name = name;
            Actived = true;
            CreateDate = DateTime.Now;
            _states = new List<State>();
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
        }

        protected City() { }
        public string Name { get; private set; }
        public bool Actived { get; private set; }
        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }
        public IReadOnlyCollection<State> States { get { return _states.ToArray(); } }

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
