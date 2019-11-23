using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPOS
{
    public class Delivery
    {
        public String DelivID { get; set; }
        public String SalesTrID { get; set; }
        //public String CustID { get; set; }
        public String AddID { get; set; }
        //public String EmpID { get; set; }
        public int Fee { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public DateTime ActualTime { get; set; }
        public String Note { get; set; }

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
