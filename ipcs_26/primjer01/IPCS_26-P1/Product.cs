using System;


namespace IPCS_26_P1
{
    class Product
    {
        private decimal price;
        private decimal tax = 0.18M;

        public void setPrice(decimal price)
        {
            this.price = price;
        }

        public decimal getPrice()
        {
            return this.price + (this.price * tax);
        }
    }
}
