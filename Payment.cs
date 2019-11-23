using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPOS
{
    public class Payment
    {
        public String PaymentID { get; set; }
        public String PaymentMethodCode { get; set; }
        public String SalesTrID { get; set; }
        public int Amount { get; set; }
        public String Status { get; set; }

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
