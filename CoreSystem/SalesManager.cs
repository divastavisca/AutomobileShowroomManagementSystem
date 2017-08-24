using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreSystem
{
    public class SalesManager
    {
        public Dictionary<DateTime, double> _salesRecord;

        public double GetTodaysSale()
        {
            return _salesRecord[DateTime.Now];
        }

        public void NewSale(double price)
        {
            double roadPrice = price + additionalCost(price);
            _salesRecord[DateTime.Now] += roadPrice;
        }

        private double additionalCost(double price)
        {
            return price * 0.08;
        }

        public SalesManager()
        {
            _salesRecord = new Dictionary<DateTime, double>();
        }
    }
}
