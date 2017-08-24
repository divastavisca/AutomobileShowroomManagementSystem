using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreSystem
{
    public class Invoice
    {
        public string Id { get; private set; }
        public double Amount { get; private set; }
        public List<Automobile> Purchases { get; private set; }
        public string CustomerDetails { get; private set; }

        public void AddPurchases(Automobile purchase)
        {
            Purchases.Add(purchase);
        }

        public void AddCustomerName(string customerName)
        {
            CustomerDetails = customerName;
        }

        public Invoice(string invoiceId, double invoiceAmount)
        {
            Id = Id;
            Amount = invoiceAmount;
        }
    }
}
