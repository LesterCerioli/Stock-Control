using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control.Domain.Entities
{
    public class ProductGroup : Entity, IAggregateRoot
    {

        private IList<Product> _products;
        public ProductGroup(Guid id, string name, bool actived)
        {
            Id = id;
            Name = name;
            Actived = actived;
            _products = new List<Product>();
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
        }

        protected ProductGroup() { }
        public string Name { get; private set; }
        public bool Actived { get; private set; }
        public IReadOnlyCollection<Product> Products { get { return _products.ToArray(); } }
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
