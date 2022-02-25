using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller
{
    public class ComposedProduct : Product
    {

        public float Discount { get; set; }

        public List<Product> Products { get; set; }
        public override string ToString()
        { string print = $"{Id}  {Description} \n";
            string names = "";
            foreach (Product product in Products) {
                names += $"{product.Description} {","}";
            } names = names.Substring(0, names.Length - 2); 
           return print += $" {"Products:"}  {names} \n {"Discount...:"}  {Discount:P2}\n {"Value.......:"}  {ValueToPay():C2}";
        }

        public override decimal ValueToPay()
        {
            if (Products != null) {
                decimal overall = 0;
                foreach (Product product in Products) {
                    overall += product.ValueToPay();
                }
                return (-overall*(decimal)Discount)+overall;
            }
            return 0;
        }
    }
}
