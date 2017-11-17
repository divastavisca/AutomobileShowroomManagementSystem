using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreSystem.Contracts
{
    public interface IServiceIncharge
    {
        bool IsAvailable();
        Automobile PerformService();
        double GetServiceFees();
    }
}
