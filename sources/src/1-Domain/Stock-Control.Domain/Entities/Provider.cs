using NetDevPack.Domain;
using Stock_Control.Domain.Core.ValueObjects;
using Stock_Control.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control.Domain.Entities
{
    public class Provider : Entity, IAggregateRoot
    {
        public Provider(Guid id, string fantasyName, string socialReason, string contactName, string phoneContact, Address address, Document document, bool actived, Email email)
        {
            Id = id;
            FantasyName = fantasyName;
            SocialReason = socialReason;
            ContactName = contactName;
            PhoneContact = phoneContact;
            Address = address;
            Document = document;
            Actived = actived;
            CreateDate = DateTimeOffset.Now;
            LastUpdateDate = DateTimeOffset.Now;
            Email = email;
        }

        protected Provider() { }
        public string FantasyName { get; private set; }
        public string SocialReason { get; private set; }
        public string ContactName { get; private set; }
        public string PhoneContact { get; private set; }
        public Address  Address { get; private set; }
        public Document Document { get; private set; }
        public bool Actived { get; private set; }
        public DateTimeOffset CreateDate { get; private set; }
        public DateTimeOffset LastUpdateDate { get; private set; }
        public Email Email { get; private set; }

        public void Activate()
        {
            Actived = true;
            LastUpdateDate = DateTimeOffset.Now;
        }

        public void Inactivate()
        {
            Actived = false;
            LastUpdateDate = DateTimeOffset.Now;
        }

    }
}
