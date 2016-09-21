using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public abstract class Peeps
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long PhoneNumber { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }

    }

    public class Customer : Peeps
    {
        public int CustomerId { get; set; }


    }

    public class Employee : Peeps
    {
        public int EmployeeId { get; set; }
        public string Title { get; set; }
        public string Wage { get; set; }
    }

    public class Supplier : Peeps
    {
        public string Company { get; set; }
    }
}
