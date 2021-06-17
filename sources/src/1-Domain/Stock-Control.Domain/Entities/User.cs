using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control.Domain.Entities
{
    public class User : Entity, IAggregateRoot
    {
        public User(Guid id, string firstName, string middleName, string lastName, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn, string email)
        {
            Id = id;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            CreatedOn = DateTimeOffset.Now;
            LastUpdatedOn = DateTimeOffset.Now;
            Email = email;
        }

        protected User() { }
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
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
