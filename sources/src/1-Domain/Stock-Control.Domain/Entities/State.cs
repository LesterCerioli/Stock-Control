using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control.Domain.Entities
{
    public class State : Entity, IAggregateRoot
    {
        private IList<Country> _countries;

        public State(Guid id, string name, string uF, bool active)
        {
            Id = id;
            Name = name;
            UF = uF;
            Active = active;
            _countries = new List<Country>();
        }

        protected State() { }
        public string Name { get; private set; }
        public string UF { get; private set; }
        public bool Active { get; private set; }

        public IReadOnlyCollection<Country> Countries { get { return _countries.ToArray(); } }
    }
}
