using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreSystem.Contracts;

namespace CoreSystem
{
    /// <summary>
    /// The manager who would manages vehicals meant to be sold
    /// </summary>
    public class SellingAutomobileManager : IAutomobileManager
    {
        private List<Automobile> _sellableAutomobiles;
        
        public bool IsAvailable(string brand, string modelSeries, string modelId)
        {
            foreach(Automobile vehical in _sellableAutomobiles)
            {
                if (vehical.Brand == brand && vehical.ModelSeries == modelSeries && vehical.ModelId == modelId)
                    return true;
            }
            return false;
        }

        public bool TryGetAutomobile(string brand, string modelSeries, string modelId, out Automobile requestedAutomobile)
        {
            foreach (Automobile vehical in _sellableAutomobiles)
            {
                if (vehical.Brand == brand && vehical.ModelSeries == modelSeries && vehical.ModelId == modelId)
                {
                    requestedAutomobile = vehical;
                    _sellableAutomobiles.Remove(vehical);
                    return true;
                }
            }
            requestedAutomobile = null;
            return false;
        }

        public bool TryRequestPrice(string brand, string modelSeries, string modelId,out double expectedPrice)
        {
            foreach (Automobile vehical in _sellableAutomobiles)
            {
                if (vehical.Brand == brand && vehical.ModelSeries == modelSeries && vehical.ModelId == modelId)
                {
                    expectedPrice= vehical.ShowroomPrice;
                    return true;
                }
            }
            expectedPrice = 0;
            return false;
        }

        public SellingAutomobileManager(List<Automobile> automobiles)
        {
            _sellableAutomobiles = automobiles;
        }
    }
}
