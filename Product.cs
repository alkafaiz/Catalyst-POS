using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPOS
{
    public class Product
    {
        //private String ProductID, Name, Description, Type, Varian, Size, Extra;
        //private int MinPurchase, ManPrice, SellPrice;
        public int MinPurchase { get; set; }
        public int? ManPrice { get; set; }
        public int? SellPrice { get; set; }
        public String ProductID { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Type { get; set; }
        public String Varian { get; set; }
        public String Size { get; set; }
        public String Extra { get; set; }
        public Image Picture { get; set; }
        public String DateCreated { get; set; }
        public bool InStock { get; set; }
        public String SubVarian { get; set; }
        public int Qty { get; set; }

        public ItemCart ItemCart
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Product()
        {

        }


        
    }
}
