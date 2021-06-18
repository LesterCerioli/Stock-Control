using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control.Domain.Entities
{
    public class Product : Entity, IAggregateRoot
    {


        private IList<MeasurementUnit> _measurementUnits;
        private IList<ProductGroup> _productGroups;
        private IList<ProductBrand> _productBrands;
        private IList<Provider> _providers;
        private IList<StorageLocal> _storageLocals;

        public Product(string code, string name, decimal costPrice, decimal salePrice, int stockAmount, string image, bool actived)
        {
            Code = code;
            Name = name;
            CostPrice = costPrice;
            SalePrice = salePrice;
            StockAmount = stockAmount;
            Image = image;
            Actived = actived;
            _measurementUnits = new List<MeasurementUnit>();
            _productGroups = new List<ProductGroup>();
            _providers = new List<Provider>();
            _storageLocals = new List<StorageLocal>();
        }

        protected Product() { }
        public string Code { get; private set; }
        public string Name { get; private set; }
        public decimal CostPrice { get; private set; }
        public decimal SalePrice { get; private set; }
        public int StockAmount { get; private set; }
             
        public string Image { get; private set; }
        public bool Actived { get; private set; }
        public IReadOnlyCollection<ProductGroup> ProductGroups { get { return _productGroups.ToArray(); } }
        public IReadOnlyCollection<ProductBrand> ProductBrands { get { return _productBrands.ToArray(); } }
        public IReadOnlyCollection<Provider> Providers { get { return _providers.ToArray(); } }
        public IReadOnlyCollection<StorageLocal> StorageLocals { get { return _storageLocals.ToArray(); } }
        public IReadOnlyCollection<MeasurementUnit> MeasurementUnits { get { return _measurementUnits.ToArray(); } }
        
    }
}
