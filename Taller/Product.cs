using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller
{
    public abstract class Product : IPay
    {
        public string Description { get; set; }

        public int Id { get; set; }

        public decimal Price { get; set; }

        public float  Tax { get; set; }

        public abstract decimal ValueToPay();

        public override string ToString()
        {
            return "";// P2 is for percentage values and C2 are for decimal values to add the point
        }

    }
}
