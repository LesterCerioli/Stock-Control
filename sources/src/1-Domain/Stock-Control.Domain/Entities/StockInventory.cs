using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control.Domain.Entities
{
    public class StockInventory : Entity, IAggregateRoot
    {

        private IList<Product> _products;
        public StockInventory(Guid id, DateTime date, string reason, int stockAmount)
        {
            Id = id;
            Date = date;
            Reason = reason;
            StockAmount = stockAmount;
            _products = new List<Product>();
            InventoryAmount = InventoryAmount;
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
        }

        protected StockInventory() { }
        public DateTime Date { get; private set; }
        public string Reason { get; private set; }
        public int StockAmount { get; private set; }
        public int InventoryAmount { get; private set; }
        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }
        public IReadOnlyCollection<Product> Products { get { return _products.ToArray(); } }
    }
}
