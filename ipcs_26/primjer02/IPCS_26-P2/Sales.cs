using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPCS_26_P2
{
    public class Sales
    {
        private Revenue salesRevenue;

        public void SetRevenue(string currency, double amount)
        {
            this.salesRevenue = new Revenue(currency, amount);
        }


        private struct Revenue
        {
            double amount;
            string currency;
            
            public Revenue(string currency, double amount)
            {
                this.currency = currency;
                this.amount = amount;
            }
        }
    }
}
