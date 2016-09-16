using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public bool Rented { get; set; }
        public string CustomerName { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Make, Model);
        }

    }

    
}
