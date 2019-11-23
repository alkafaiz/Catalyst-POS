using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPOS
{
    public class SalesTransaction
    {
        public Customer Customer { get; set; }
        public Delivery Delivery { get; set; }
        public List<Product> Products { get; set; }
        public Payment Payment { get; set; }
        public Address Address { get; set; }
        public String EmpID { get; set; }        
        public String DiscCode { get; set; }        
        public String Type { get; set; }
        public int ManPrice { get; set; }
        public int TotalPrice { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime TimeCreated { get; set; }
        public String Status { get; set; }

        public String DelivID { get; set; }
        public String PaymentID { get; set; }
        public String SalesTrID { get; set; }
        public String CustID { get; set; }

        public Employee Employee
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
