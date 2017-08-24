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
            return _salesRecord[DateTime.Today.Date];
        }

        public Invoice NewSale(double price)
        {
            double roadPrice = price + additionalCost(price);
            if (_salesRecord.ContainsKey(DateTime.Today.Date))
                _salesRecord[DateTime.Today.Date] += roadPrice;
            else _salesRecord.Add(DateTime.Today.Date, roadPrice);
            return new Invoice(getNewInvoiceId(), roadPrice);
        }

        private double additionalCost(double price)
        {
            return price * 0.08;
        }


        private string getNewInvoiceId()
        {
            return null;
        }
        public SalesManager()
        {
            _salesRecord = new Dictionary<DateTime, double>();
        }
    }
}
