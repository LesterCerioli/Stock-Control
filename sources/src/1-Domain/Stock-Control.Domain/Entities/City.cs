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
        public City(Guid id, string name, bool active)
        {
            Id = id;
            Name = name;
            Active = active;
            _states = new List<State>();
        }

        protected City() { }
        public string Name { get; private set; }
        public bool Active { get; private set; }
        public IReadOnlyCollection<State> States { get { return _states.ToArray(); } }
    
    }
}
