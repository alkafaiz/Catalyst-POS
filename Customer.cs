using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPOS
{
    public class Customer
    {
        public Customer()
        {

        }
        public String CustID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime DoB { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
        public String Occupation { get; set; }
        public int Point { get; set; }
        public DateTime RegistrationDate { get; set; }

        public SalesTransaction SalesTransaction
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}
