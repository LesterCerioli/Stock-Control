using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control.Domain.Entities
{
    public class ProductInput : Entity, IAggregateRoot
    {
        private IList<Product> _products;

        public ProductInput(Guid id, string number, DateTime date, int amount)
        {
            Id = id;
            Number = number;
            Date = DateTime.Now;
            Amount = amount;
            _products = new List<Product>();
        }

        
        protected ProductInput() { }
        public string Number { get; private set; }
        public DateTime Date { get; private set; }
        public int Amount { get; private set; }

        
        public IReadOnlyCollection<Product> Products { get { return _products.ToArray(); } }

    }
}
