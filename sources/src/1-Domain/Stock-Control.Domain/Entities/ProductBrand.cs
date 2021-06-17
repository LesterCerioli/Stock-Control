using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control.Domain.Entities
{

    
    public class ProductBrand : Entity, IAggregateRoot
    {
        private IList<Product> _products;

        public ProductBrand(Guid id, string name, bool actived)
        {
            Id = id;
            Name = name;
            Actived = actived;
            _products = new List<Product>();
        }

        protected ProductBrand() { }
        public string Name { get; private set; }
        public bool Actived { get; private set; }
           

        public IReadOnlyCollection<Product> Products { get { return _products.ToArray(); } }
    }
}
