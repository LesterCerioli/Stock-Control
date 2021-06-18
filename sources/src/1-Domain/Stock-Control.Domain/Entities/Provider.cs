using NetDevPack.Domain;
using Stock_Control.Domain.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control.Domain.Entities
{
    public class Provider : Entity, IAggregateRoot
    {

        protected Provider() { }
        public string FantasyName { get; private set; }
        public string SocialReason { get; private set; }
        public string ContactName { get; private set; }
        public string PhoneContact { get; private set; }
        public Address  Address { get; private set; }

    }
}
