using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreSystem.Contracts;

namespace CoreSystem
{
    public class SellingServiceIncharge : IServiceIncharge
    {
        private IAutomobileManager _sellingManager;
        private SalesManager _salesManager;
        private string _brand;
        private string _modelSeries;
        private string _modelId;

        public double GetServiceFees()
        {
            double value = 0;
            _sellingManager.TryRequestPrice(_brand, _modelSeries, _modelId,out value);
            return value;
        }

        public bool IsAvailable()
        {
            return _sellingManager.IsAvailable(_brand, _modelSeries, _modelId);
        }

        public Automobile PerformService()
        {
            Automobile customerRequirement = null;
            double value;
            _sellingManager.TryRequestPrice(_brand, _modelSeries, _modelId, out value);
            _salesManager.NewSale(value);
            _sellingManager.TryGetAutomobile(_brand, _modelSeries, _modelId, out customerRequirement);
            return customerRequirement;
        }

        public SellingServiceIncharge(string brand,string modelSeries,string modelId,SellingAutomobileManager concernedManager,SalesManager salesManager)
        {
            _brand = brand;
            _modelSeries = modelSeries;
            _modelId = modelId;
            _sellingManager = concernedManager;
            _salesManager = salesManager;
        }
    }
}
