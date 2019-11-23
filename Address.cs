using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPOS
{
    public class Address
    {
        public Address()
        {

        }

        public String AddID { get; set; }
        public String CustID { get; set; }
        public String Label { get; set; }
        public String Province { get; set; }
        public String City { get; set; }
        public String District { get; set; }
        public String Addres { get; set; }
        public int Postcode { get; set; }
        public String Subdistrict { get; set; }

        public Customer Customer
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Delivery Delivery
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
