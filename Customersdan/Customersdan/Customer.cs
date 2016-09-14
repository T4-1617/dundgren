using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customersdan
{
    class Customer
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int id { get; set; }

        public string fullname() {

            return string.Format("{0} {1}", firstname, lastname);

    }

        public bool active { get; set; }

    }
}
