using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller
{
    public class VariablePriceProduct : Product
    {
        public string Measurement{ get; set; }
        public float Quantity{ get; set; }
        public override decimal ValueToPay()
        {
            return ((((decimal)Tax * Price))+Price)*(decimal)Quantity;
        }
        public override string ToString()
        {
            return $"{Id}   {Description} \n {"Measurement:"}  {Measurement}\n  {"Quantity:"}  {Quantity}\n {"Price....:"}  {Price:C2}\n {"Tax......:"}  {Tax:P2}\n {"Value....:"}  {ValueToPay():C2}";
        }
    }
}
