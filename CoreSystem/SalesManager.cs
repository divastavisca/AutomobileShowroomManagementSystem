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
            return _salesRecord[DateTime.Today];
        }

        public void NewSale(double price)
        {
            double roadPrice = price + additionalCost(price);
            if (_salesRecord.ContainsKey(DateTime.Today))
                _salesRecord[DateTime.Today] += roadPrice;
            else _salesRecord.Add(DateTime.Today, roadPrice);
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
