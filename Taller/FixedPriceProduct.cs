using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller
{
    public class FixedPriceProduct : Product
    {

        public override decimal ValueToPay()
        {
            return ((decimal)Tax*Price)+Price;
        }
        public override string ToString()
        {
            return $"{Id}   {Description} \n {"Price....:"}  {Price:C2}\n {"Tax......:"}  {Tax:P2}\n {"Value....:"}  {ValueToPay():C2}";
        }
    }
}
