using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreSystem.Contracts;

namespace CoreSystem
{
    public class RentingAutomobileManager : IAutomobileManager
    {
        private List<Automobile> _rentableAutomobiles;

        private Dictionary<Automobile, double> _rentAmount;

        public bool IsAvailable(string brand, string modelSeries, string modelId)
        {
            foreach (Automobile vehical in _rentableAutomobiles)
            {
                if (vehical.Brand == brand && vehical.ModelSeries == modelSeries && vehical.ModelId == modelId)
                    return true;
            }
            return false;
        }

        public bool TryGetAutomobile(string brand, string modelSeries, string modelId, out Automobile requestedAutomobile)
        {
            foreach (Automobile vehical in _rentableAutomobiles)
            {
                if (vehical.Brand == brand && vehical.ModelSeries == modelSeries && vehical.ModelId == modelId)
                {
                    requestedAutomobile = vehical;
                    _rentableAutomobiles.Remove(vehical);
                    return true;
                }
            }
            requestedAutomobile = null;
            return false;
        }

        public bool TryRequestPrice(string brand, string modelSeries, string modelId, out double expectedPrice)
        {
            foreach (Automobile vehical in _rentableAutomobiles)
            {
                if (vehical.Brand == brand && vehical.ModelSeries == modelSeries && vehical.ModelId == modelId)
                {
                    expectedPrice = _rentAmount[vehical];
                    return true;
                }
            }
            expectedPrice = 0;
            return false;
        }

        public RentingAutomobileManager(List<Automobile> automobiles,Dictionary<Automobile,double> rentDefault)
        {
            _rentableAutomobiles = automobiles;
            _rentAmount = rentDefault;
        }
    }
}
