using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class cars
    {
        public string name { get; set; }
        public string fuel  { get; set; }
        public string hp { get; set; }
        public string trunksize { get; set; }
        public string seats { get; set; }

    }

    public override string ToString() {
        return string.Format("Namn: {0}\n Drivmedel: {1}\n Hästkrafter: {2}\n Baggageutrymme: {3}\n Platser: {4}", name, fuel, hp, trunksize, seats);
    }
}
