using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller
{
    public class Invoice : IPay
    {

        private List<Product> _products { get; set; }

        public Invoice()
        {
            _products = new List<Product>();    
        }


        public void AddProduct(Product product)
        {
           _products.Add(product);        
        }

         public decimal ValueToPay() {
            if (_products != null)
            {
                decimal overall = 0;
                foreach (Product product in _products) {
                    overall += product.ValueToPay();
                }
                return overall;
            }
            else
                return 0;
         }
        override public string ToString() {
            string print=$"{"RECEIPT"}\n{"-----------------------------------"}\n";
            foreach (Product product in _products) 
            {
                print += $"{product.ToString()}\n";
            } 
            return print += $"{"                ==========="}\n{"TOTAL:"}          {ValueToPay():C2}"; 
        }
    }
}
