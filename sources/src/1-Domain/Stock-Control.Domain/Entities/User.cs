using NetDevPack.Domain;
using Stock_Control.Domain.Enums;
using Stock_Control.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control.Domain.Entities
{
    public class User : Entity, IAggregateRoot
    {
        public User(Guid id, Name name, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn, string email)
        {
            Id = id;
            Name = name;
            CreatedOn = DateTimeOffset.Now;
            LastUpdatedOn = DateTimeOffset.Now;
            Email = email;
        }

        protected User() { }
        public Name Name { get; private set; }
        public DateTimeOffset CreatedOn { get; private set; }
        public DateTimeOffset LastUpdatedOn { get; private set; }
        public string Email { get; private set; }
        public bool Actived { get; private set; }

        public void Activate()
        {
            Actived = true;
            LastUpdatedOn = DateTimeOffset.Now;
        }

        public void Inactive()
        {
            Actived = false;
            LastUpdatedOn = DateTimeOffset.Now;
        }
    }
}
