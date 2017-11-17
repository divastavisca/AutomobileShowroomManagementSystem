using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreSystem.Contracts
{
    public interface IAutomobileManager
    {
        bool IsAvailable(string brand,string modelSeries,string modelId);
        bool TryGetAutomobile(string brand, string modelSeries, string modelId, out Automobile requestedAutomobile);
        bool TryRequestPrice(string brand, string modelSeries, string modelId, out double expectedPrice);
    }
}
