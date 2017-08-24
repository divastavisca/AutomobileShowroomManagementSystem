using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreSystem.Contracts;

namespace CoreSystem
{
    public class RentingServiceIncharge : IServiceIncharge
    {
        private IAutomobileManager _rentingManager;
        private SalesManager _salesManager;
        private string _brand;
        private string _modelSeries;
        private string _modelId;

        public double GetServiceFees()
        {
            double value = 0;
            _rentingManager.TryRequestPrice(_brand, _modelSeries, _modelId, out value);
            return value;
        }

        public bool IsAvailable()
        {
            return _rentingManager.IsAvailable(_brand, _modelSeries, _modelId);
        }

        public Automobile PerformService(out Invoice userReciept)
        {
            Automobile customerRequirement = null;
            double value;
            _rentingManager.TryRequestPrice(_brand, _modelSeries, _modelId, out value);
            userReciept = _salesManager.NewSale(value);
            _rentingManager.TryGetAutomobile(_brand, _modelSeries, _modelId, out customerRequirement);
            return customerRequirement;
        }

        public RentingServiceIncharge(string brand, string modelSeries, string modelId, RentingAutomobileManager concernedManager, SalesManager salesManager)
        {
            _brand = brand;
            _modelSeries = modelSeries;
            _modelId = modelId;
            _rentingManager = concernedManager;
            _salesManager = salesManager;
        }
    }
}
