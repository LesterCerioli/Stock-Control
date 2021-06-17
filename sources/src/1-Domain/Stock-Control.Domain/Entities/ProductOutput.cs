using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control.Domain.Entities
{

    
    public class ProductOutput : Entity, IAggregateRoot
    {

        private IList<Product> _products;
        public ProductOutput(Guid id, string number, DateTime date, DateTime creteDate, DateTime lastUpdateDate)
        {
            Id = id;
            Number = number;
            Date = date;
            CreteDate = creteDate;
            LastUpdateDate = lastUpdateDate;
            _products = new List<Product>();
        }

        protected ProductOutput() { }
        public string Number { get; private set; }
        public DateTime Date { get; private set; }
        public DateTime CreteDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }
        public IReadOnlyCollection<Product> Products { get { return _products.ToArray(); } }
    }
}
