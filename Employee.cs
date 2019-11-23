using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace SmartPOS
{
    public class Employee
    {
        public String EmpID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Role { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public DateTime DoB { get; set; }

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

        Connection conn = new Connection();
        public Employee()
        {

        }

        //public byte[] ConvertImageToBinary(Image img)
        //{
        //    using(MemoryStream ms = new MemoryStream())
        //    {
        //        img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
        //        return ms.ToArray();
        //    }
        //}
        //convert to product class(later remove)
        public void addProduct(List<Product> product)
        {
            DateTime dt = new DateTime();

            for (int a = 0; a < product.Count; a++)
            {
                product[a].Picture = product[0].Picture;
                String name = product[a].Varian + " " + product[a].Size + " " + product[a].Type + " with " + product[a].Extra;
                product[a].Name = name;
                Guid ID = Guid.NewGuid();
                product[a].ProductID = ID.ToString();
            }         
            for (int i = 0; i < product.Count; i++)
            {

                conn.getConnected.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Product (ProductID, Name, Description, Type, Varian, Size, MinPurchase, ManPrice, SellPrice, Picture,Extra,DateCreate,InStock) 
                VALUES('" + product[i].ProductID + 
                "', '" + product[i].Name + 
                "', '" + product[i].Description + 
                "','" + product[i].Type + 
                "', '" + product[i].Varian + 
                "', '" + product[i].Size + 
                "', '" + product[i].MinPurchase + 
                "', '" + product[i].ManPrice + 
                "', '" + product[i].SellPrice + 
                //"', '" + ConvertImageToBinary(product[i].Picture) +
                "', '" + product[i].Extra +
                "', '" + DateTime.Today +
                "', '" + "false" +
                //"', '" + product[i].DateCreated +
                "')", conn.getConnected);
                cmd.ExecuteNonQuery();
                conn.getConnected.Close();
            }
            
        }

        //public Image ConvertBinaryToImage(DataSet ds)
        //{
        //    using (MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0][0]))
        //    {
        //        Console.WriteLine(Convert.ToString(ds.Tables[0].Rows[0][0]));
        //        Console.WriteLine(ds.Tables[0].Rows.Count);
        //        //return Image.FromStream(ms);
        //        Image a;
        //        return a = new Bitmap(ms);
        //    }
        //}

        public Image loadImage(Product pr) 
        {
            if (conn.getConnected.State != ConnectionState.Open) { conn.getConnected.Open(); }
            SqlDataAdapter sda = new SqlDataAdapter("Select Picture from Product where ProductID='"+pr.ProductID+"' ", conn.getConnected);
            DataSet dt = new DataSet();
            sda.Fill(dt);
            if (string.IsNullOrEmpty(dt.Tables[0].Rows[0][0].ToString()) != true)
            {
                MemoryStream ms = new MemoryStream((byte[])dt.Tables[0].Rows[0][0]);
                Image pic = new Bitmap(ms);
                conn.getConnected.Close();
                return pic;
            }
            else { conn.getConnected.Close(); return null; }                        
        }

        public void testingcopyimage(String varian)
        {
            try
            {
                
                conn.getConnected.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select ProductID, Picture from Product where Varian= '"+varian+"' ", conn.getConnected);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                int n = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (string.IsNullOrEmpty(dt.Rows[i][1].ToString()) != true)
                    {
                        n += i;
                        break;
                    }
                }
                MemoryStream ms= new MemoryStream((byte[])dt.Rows[n][1]); ;
                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                //    if (dt.Rows[i][1] != null)
                //    {
                //        ms = new MemoryStream((byte[])dt.Rows[i][1]);
                //        break;
                //    }
                //}


                byte[] img = null;                
                BinaryReader br = new BinaryReader(ms);
                img = br.ReadBytes((int)ms.Length); int x = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string sql = "UPDATE Product SET Picture = @img WHERE ProductID='" + dt.Rows[i][0] + "' ";
                    if (conn.getConnected.State != ConnectionState.Open) { conn.getConnected.Open(); }
                    SqlCommand Command = new SqlCommand(sql, conn.getConnected);
                    Command.Parameters.Add(new SqlParameter("@img", img));
                    Command.ExecuteNonQuery();
                        x += 1;
                }                                                               
                conn.getConnected.Close();
                MessageBox.Show(x.ToString() + " picture has been updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateImage(Product pr, String imgloc) 
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);                
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                string sql = "UPDATE Product SET Picture = @img WHERE ProductID='" + pr.ProductID + "' ";
                if (conn.getConnected.State != ConnectionState.Open) { conn.getConnected.Open(); }
                SqlCommand Command = new SqlCommand(sql, conn.getConnected);
                Command.Parameters.Add(new SqlParameter("@img", img));
                int x = Command.ExecuteNonQuery();
                conn.getConnected.Close();
                MessageBox.Show(x.ToString() + " picture of " + pr.Name + " has been updated.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<String> loadVarian()
        {
            List<String> varians = new List<string>();
            conn.getConnected.Open();
            SqlCommand cmd = new SqlCommand("Select Varian from Product Group by Varian", conn.getConnected);
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                varians.Add(dr[0].ToString());                
            }
            dr.Close();
            conn.getConnected.Close();
            return varians;
        }

        public List<String> loadVarian(String Type)
        {
            conn.getConnected.Open();
            List<String> varians = new List<string>();
            if (Type == "PIZZA")
            {                
                SqlCommand cmd = new SqlCommand("SELECT [Varian] FROM [dbo].[Product] WHERE [Type] = 'PIZZA' GROUP BY VARIAN", conn.getConnected);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    varians.Add(dr[0].ToString());
                }
                dr.Close();                     
            }
            conn.getConnected.Close();
            return varians;

        }

        public void addProduct(Product product)
        {
            DateTime dt = new DateTime();
            conn.getConnected.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Product (ProductID, Name, Description, Type, Varian, Size, MinPurchase, ManPrice, SellPrice, Extra,DateCreate,InStock, Subvarian) 
                VALUES('" + product.ProductID +
            "', '" + product.Name +
            "', '" + product.Description +
            "','" + product.Type +
            "', '" + product.Varian +
            "', '" + product.Size +
            "', '" + product.MinPurchase +
            "', '" + product.ManPrice +
            "', '" + product.SellPrice +
            //"', '" + ConvertImageToBinary(product.Picture) +
            "', '" + product.Extra +
            "', '" + DateTime.Today +
            "', '" + "false" +
            "', '" + product.SubVarian +
            //"', '" + product[i].DateCreated +
            "')", conn.getConnected);
            cmd.ExecuteNonQuery();
            conn.getConnected.Close();

        }

        public void addCustomer(Customer cus)
        {            
            conn.getConnected.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Customer (CustID, FirstName, LastName, DoB, Phone, Email, Occupation, Point,RegistrationDate) 
                VALUES('" + cus.CustID +            
            "', '" + cus.FirstName +
            "','" + cus.LastName +
            "', '" + cus.DoB +
            "', '" + cus.Phone +
            "', '" + cus.Email +
            "', '" + cus.Occupation +
            "', '" + cus.Point +            
            "', '" + DateTime.Today +
            "')", conn.getConnected);
            cmd.ExecuteNonQuery();
            conn.getConnected.Close();
        }

        public void addAddress(Address add)
        {
            conn.getConnected.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Address (AddID, CustID, Label, Province, City, District, Address, Postcode, Subdistrict) 
                VALUES('" + add.AddID +
            "', '" + add.CustID +
            "','" + add.Label +
            "', '" + add.Province +
            "', '" + add.City +
            "', '" + add.District +
            "', '" + add.Addres +
            "', '" + add.Postcode +
            "', '" + add.Subdistrict +
            "')", conn.getConnected);
            cmd.ExecuteNonQuery();
            conn.getConnected.Close();
        }

        

        public List<Product> loadProducts()
        {
            List<Product> products = new List<Product>();
            conn.getConnected.Open();
            SqlCommand cmd = new SqlCommand(@"Select * From Product", conn.getConnected);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Product pr = new Product();
                pr.ProductID = dr[0].ToString();
                pr.Name = dr[1].ToString();
                pr.Description = dr[2].ToString();
                pr.Type = dr[3].ToString();
                pr.Varian = dr[4].ToString();
                pr.Size = dr[5].ToString();
                pr.MinPurchase = Convert.ToInt32(dr[6].ToString());
                pr.ManPrice = Convert.ToInt32(dr[7].ToString());
                pr.SellPrice = Convert.ToInt32(dr[8].ToString());
                //try read bit pict
                //MemoryStream ms = new MemoryStream(picArr);
                ////ms.Seek(0, SeekOrigin.Begin);
                //pr.Picture = Image.FromStream(ms);

                //command for trial
                //byte[] picArr = (byte[])dr[9];                
                //if (String.IsNullOrEmpty(dr[9].ToString())) { pr.Picture = loadImage(pr); }


                //get picture not using function
                if (string.IsNullOrEmpty(dr[9].ToString()) != true)
                {
                    MemoryStream ms = new MemoryStream((byte[])dr[9]);
                    Image pic = new Bitmap(ms);
                    pr.Picture = pic;
                }
                pr.Extra = dr[10].ToString();
                pr.DateCreated = dr[11].ToString();
                Console.WriteLine("this is " + dr[12].ToString());
                if (dr[12].ToString() == "True")
                {
                    
                    pr.InStock = true;
                }
                else { pr.InStock = false; }                
                pr.SubVarian = dr[13].ToString();
                products.Add(pr);
            }
            dr.Close();
            conn.getConnected.Close();
            return products;
        }

        public Product loadProduct(String IDs)
        {
            //String ID = IDs.Trim();
            //Product pr = new Product();
            //using (var c = conn.getConnected)
            //{
            //    using (var cmd = new SqlCommand(@"Select * From Product Where ProductID like '" + ID + "'", c))
            //    {
            //        c.Open();                    
            //        using (var dr = cmd.ExecuteReader())
            //        {
            //            while (dr.Read())
            //            {
            //                pr.ProductID = dr[0].ToString();
            //                pr.Name = dr[1].ToString();
            //                pr.Description = dr[2].ToString();
            //                pr.Type = dr[3].ToString();
            //                pr.Varian = dr[4].ToString();
            //                pr.Size = dr[5].ToString();
            //                pr.MinPurchase = Convert.ToInt32(dr[6].ToString());
            //                pr.ManPrice = Convert.ToInt32(dr[7].ToString());
            //                pr.SellPrice = Convert.ToInt32(dr[8].ToString());
            //                pr.Extra = dr[10].ToString();
            //                pr.DateCreated = dr[11].ToString();
            //                Console.WriteLine("hahaha  " + dr[12].ToString());
            //                if (dr[12].ToString() == "True")
            //                {
            //                    pr.InStock = true;
            //                    Console.WriteLine("aalalala  " + pr.InStock.ToString());
            //                }
            //                else { pr.InStock = false; }
            //                pr.SubVarian = dr[13].ToString();
            //            }
            //        }
            //    }
            //No need to explicitly close connection :) Thanks to "using"
            //}
            //return pr;            
            //backup
            if(conn.getConnected.State == ConnectionState.Closed) { conn.getConnected.Open(); }
            
            String ID = IDs.Trim();
            Product pr = new Product();
            SqlCommand cmd = new SqlCommand(@"Select * From Product Where ProductID like '" + ID + "'", conn.getConnected);
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {

                    pr.ProductID = dr[0].ToString();
                    pr.Name = dr[1].ToString();
                    pr.Description = dr[2].ToString();
                    pr.Type = dr[3].ToString();
                    pr.Varian = dr[4].ToString();
                    pr.Size = dr[5].ToString();
                    pr.MinPurchase = Convert.ToInt32(dr[6].ToString());
                    pr.ManPrice = Convert.ToInt32(dr[7].ToString());
                    pr.SellPrice = Convert.ToInt32(dr[8].ToString());
                    //if (string.IsNullOrEmpty(dr[9].ToString()) != true)
                    //{
                    //    MemoryStream ms = new MemoryStream((byte[])dr[9]);
                    //    Image pic = new Bitmap(ms);
                    //    pr.Picture = pic;
                    //}
                    pr.Extra = dr[10].ToString();
                    pr.DateCreated = dr[11].ToString();
                    Console.WriteLine("hahaha  " + dr[12].ToString());
                    if (dr[12].ToString() == "True")
                    {
                        pr.InStock = true;
                        Console.WriteLine("aalalala  " + pr.InStock.ToString());
                    }
                    else { pr.InStock = false; }
                    pr.SubVarian = dr[13].ToString();
                }
                dr.Close();
                conn.getConnected.Close();
                Console.WriteLine("the name is " + pr.Name);
                return pr;
            }
        }

        public List<Customer> loadCustomer()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Customer", conn.getConnected);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            List<Customer> cuss = new List<Customer>();
            foreach (DataRow item in dt.Rows)
            {
                Customer cus = new Customer();
                cus.CustID = item[0].ToString();
                cus.FirstName = item[1].ToString();
                cus.LastName = item[2].ToString();
                cus.DoB = Convert.ToDateTime(item[3]);
                cus.Phone = item[4].ToString();
                cus.Email = item[5].ToString();
                cus.Occupation = item[6].ToString();
                cus.Point = Convert.ToInt32(item[7].ToString());
                cus.RegistrationDate = Convert.ToDateTime(item[8]);
                cuss.Add(cus);
            }
            return cuss;
        }

        public List<Customer> loadCustomer(DataGridView dataGridView1)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Customer", conn.getConnected);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            List<Customer> cuss = new List<Customer>();
            foreach (DataRow item in dt.Rows)
            {
                Customer cus = new Customer();
                cus.CustID = item[0].ToString();
                cus.FirstName = item[1].ToString();
                cus.LastName = item[2].ToString();
                cus.DoB = Convert.ToDateTime(item[3]);
                cus.Phone = item[4].ToString();
                cus.Email = item[5].ToString();
                cus.Occupation = item[6].ToString();
                cus.Point = Convert.ToInt32(item[7].ToString());
                cus.RegistrationDate = Convert.ToDateTime(item[8]);
                cuss.Add(cus);
            }
            foreach (Customer cs in cuss)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = cs.CustID;
                dataGridView1.Rows[n].Cells[1].Value = cs.FirstName + " " + cs.LastName;
                dataGridView1.Rows[n].Cells[2].Value = cs.RegistrationDate.ToString();
                dataGridView1.Rows[n].Cells[3].Value = loadLatestPurchase(cs.CustID);                
            }
            return cuss;
        }

        public Customer loadCustomer(String ID)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Customer Where CustID like '" + ID + "'", conn.getConnected);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Customer cus = new Customer();
            foreach (DataRow item in dt.Rows)
            {                
                cus.CustID = item[0].ToString();
                cus.FirstName = item[1].ToString();
                cus.LastName = item[2].ToString();
                cus.DoB = Convert.ToDateTime(item[3]);
                cus.Phone = item[4].ToString();
                cus.Email = item[5].ToString();
                cus.Occupation = item[6].ToString();
                cus.Point = Convert.ToInt32(item[7].ToString());
                cus.RegistrationDate = Convert.ToDateTime(item[8]);
                break;
            }
            
            return cus;
        }

        public List<Address> loadAddress(Customer cust)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Address where CustID like '"+cust.CustID+"' ", conn.getConnected);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            List<Address> addresses = new List<Address>();
            foreach (DataRow item in dt.Rows)
            {
                Address add = new Address();
                add.AddID = item[0].ToString();
                add.CustID = item[1].ToString();
                add.Label = item[2].ToString();
                add.Province = item[3].ToString();
                add.City = item[4].ToString();
                add.District = item[5].ToString();
                add.Addres = item[6].ToString();
                add.Postcode = Convert.ToInt32(item[7].ToString());
                add.Subdistrict = item[8].ToString();
                addresses.Add(add);
            }
            return addresses;
        }

        public int countrowProduct()
        {
            conn.getConnected.Open();
            SqlCommand cmd = new SqlCommand(@"Select COUNT(*) From Product", conn.getConnected);
            int n = Convert.ToInt32(cmd.ExecuteScalar());
            conn.getConnected.Close();
            return n;
        }

//        public Image getimage()
//        {
//            conn.getConnected.Open();
//            SqlCommand cmd = new SqlCommand(@"Select Picture from Product", conn.getConnected);
////            SqlDataReader dr = cmd.ExecuteReader();
            
//            SqlDataAdapter da = new SqlDataAdapter(cmd);

//            DataSet ds = new DataSet();
            
//            da.Fill(ds);

//            Image f;
           
//                f = ConvertBinaryToImage((byte)ds.Tables[0].Rows[0]["Picture"]);
            
//            return f;
//            }

        public void updateProduct(Product pr)
        {
            conn.getConnected.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Product SET Name ='" + pr.Name + 
                "' , Description ='" + pr.Description + 
                "', Varian ='" + pr.Varian +
                "', Subvarian ='" + pr.SubVarian +
                "', Size ='" + pr.Size +
                "', MinPurchase ='" + pr.MinPurchase +
                "', ManPrice ='" + pr.ManPrice + 
                "', SellPrice ='" + pr.SellPrice + 
                "', Extra ='" + pr.Extra +                 
                "' WHERE (ProductID='" + pr.ProductID + "')", conn.getConnected);
            cmd.ExecuteNonQuery();
            conn.getConnected.Close();
        }
        //updatepic later can combine
        public void updateProduct(Product pr, Byte[] image)
        {
            conn.getConnected.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Product SET Picture ='" + image +              
                "' WHERE (ProductID='" + pr.ProductID + "')", conn.getConnected);
            cmd.ExecuteNonQuery();
            conn.getConnected.Close();
        }
        public void SaveUser(DataGridView dgv)
        {
            int n = dgv.Rows.Count;
            conn.getConnected.Open();
            for (int i = 0; i < n; i++)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Employee SET FirstName ='" + dgv.Rows[i].Cells[1].Value.ToString() +
                "' , LastName ='" + dgv.Rows[i].Cells[2].Value.ToString() +
                "', Role ='" + dgv.Rows[i].Cells[3].Value.ToString() +
                "', Username ='" + dgv.Rows[i].Cells[4].Value.ToString() +
                "', Password ='" + dgv.Rows[i].Cells[5].Value.ToString() +
                "', DoB ='" + dgv.Rows[i].Cells[6].Value.ToString() +                
                "' WHERE (EmpID='" + dgv.Rows[i].Cells[0].Value.ToString() + "')", conn.getConnected);
                cmd.ExecuteNonQuery();
            }
            conn.getConnected.Close();
        }

        public void activateProduct(Product pr)
        {
            if (conn.getConnected.State == ConnectionState.Closed)
            {
                conn.getConnected.Open();
            }
            
                SqlCommand cmd = new SqlCommand("UPDATE Product SET InStock ='" + pr.InStock +
                "' WHERE (ProductID='" + pr.ProductID + "')", conn.getConnected);
                cmd.ExecuteNonQuery();
            
            
            conn.getConnected.Close();
            
        }

        public void loadProducts(List<Product> prods, FlowLayoutPanel flowlyt)
        {
            if (prods.Count == 0) { Console.WriteLine("No product"); }
            else
            {
                for (int i = 0; i < prods.Count; i++)
                {
                    if (prods[i].InStock == true)
                    {
                        ItemCard item = new ItemCard(prods[i], "Pizza-selection");
                        item.NameProduct = prods[i].Name;
                        item.Price = "Rp." + prods[i].SellPrice.ToString();
                        item.Pic = prods[i].Picture;
                        flowlyt.Controls.Add(item);
                    }
                }
            }
        }

        public void addToCart(Product prod, FlowLayoutPanel flowlyt)
        {            
            ItemCart cart = new ItemCart(prod);
            cart.NameProduct = prod.Name;
            cart.Price = prod.SellPrice;
            flowlyt.Controls.Add(cart);            
        }

        public void calculateSubTotal(FlowLayoutPanel fl, TextBox subtotal, TextBox total,TextBox discount, TextBox fee)
        {
            int n = 0;
            //List<Control> listControls = new List<Control>();
            foreach (ItemCart control in fl.Controls.OfType<ItemCart>())
            {
                //listControls.Add(control);
                Console.WriteLine(control.Price);
                n += Convert.ToInt32(control.Price);
            }
            subtotal.Text = n.ToString();
            int dis = Convert.ToInt32(discount.Text);
            int fees = Convert.ToInt32(fee.Text);
            n += fees;
            n -= dis;

            total.Text = n.ToString();
            //return n;   


        }

        public int calculateManTotal(List<Product> prods)
        {
            int n = 0;
            foreach (Product item in prods)
            {
                int s = Convert.ToInt32(item.ManPrice);
                int qty = item.Qty;
                int total = s * qty;
                n += total;
            }
            return n;
        }

        public void loadPaymentMethod(ComboBox combo)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from PaymentMethod", conn.getConnected);
            DataTable dt = new DataTable();
            sda.Fill(dt);            
            foreach (DataRow item in dt.Rows)
            {                
                combo.Items.Add(item[1].ToString());                
            }            
        }

        public String loadPaymentMethod(String mthdchosen)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from PaymentMethod", conn.getConnected);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            String id = "";
            foreach (DataRow item in dt.Rows)
            {
                if (item[1].ToString() == mthdchosen)
                {
                    id = item[0].ToString();break;
                }                
            }
            return id;
        }

        public List<Product> loadCartProduct(FlowLayoutPanel fl)
        {            
            List<Product> prd = new List<Product>();
            foreach (ItemCart control in fl.Controls.OfType<ItemCart>())
            {
                Product pr = control.Productgetset;
                pr.Qty = control.Qty;
                prd.Add(pr);
            }
            return prd;            
        }

        public void loadCartProduct(List<Product> prod, FlowLayoutPanel fl)
        {
            foreach (Product pr in prod)
            {
                ItemCart item = new ItemCart(pr, "review");
                item.NameProduct = pr.Name;
                item.Qty = pr.Qty;
                item.Price = pr.SellPrice*pr.Qty;
                fl.Controls.Add(item);
            }            
        }

        public void createDelivery(Delivery dv)
        {
            conn.getConnected.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Delivery (DelivID, SalesTrID, AddID, Fee, Date, Time,Note) 
                VALUES('" + dv.DelivID +
            "', '" + dv.SalesTrID +
            "', '" + dv.AddID +
            "','" + dv.Fee +
            "', '" + dv.Date +
            "', '" + dv.Time +            
            "', '" + "none" +            
            "')", conn.getConnected);
            cmd.ExecuteNonQuery();
            conn.getConnected.Close();
        }

        public Delivery loadDelivery(String salesID)
        {
            conn.getConnected.Open();
            Delivery dv = new Delivery();
            SqlCommand cmd = new SqlCommand(@"Select * From Delivery Where SalesTrID like '" + salesID + "'", conn.getConnected);
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    dv.DelivID = dr[0].ToString();
                    dv.SalesTrID = dr[1].ToString();
                    dv.AddID = dr[2].ToString();
                    dv.Fee = Convert.ToInt32(dr[3].ToString());
                    dv.Date = Convert.ToDateTime(dr[4].ToString());
                    dv.Time = Convert.ToDateTime(dr[5].ToString());
                    if (String.IsNullOrEmpty(dr[6].ToString()) == false) { dv.ActualTime = Convert.ToDateTime(dr[6].ToString()); }
                    dv.Note = dr[7].ToString();                    
                }
                dr.Close();
                conn.getConnected.Close();                                
            }
            return dv;
        }

        public Payment createPayment(String PaymentID, String PaymentMethodCode, String SalesTrID, int Amount, String Status)
        {
            Payment py = new Payment();
            py.PaymentID = PaymentID;
            py.PaymentMethodCode = PaymentMethodCode;
            py.SalesTrID = SalesTrID;
            py.Amount = Amount;
            py.Status = Status;
            return py;
        }

        public void createPayment(Payment py)
        {
            conn.getConnected.Open();
            //for SalesTransaction
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Payment (PaymentID, PaymentMethodCode, SalesTrID, Amount, Status) 
                VALUES('" + py.PaymentID +
            "', '" + py.PaymentMethodCode +
            "', '" + py.SalesTrID +
            "','" + py.Amount +
            "', '" + py.Status +            
            "')", conn.getConnected);
            cmd.ExecuteNonQuery();
            conn.getConnected.Close();
        }

        public Payment loadPayment(String salesID)
        {
            conn.getConnected.Open();
            Payment p = new Payment();
            SqlCommand cmd = new SqlCommand(@"Select * From payment Where SalesTrID like '" + salesID + "'", conn.getConnected);
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    p.PaymentID = dr[0].ToString();
                    p.PaymentMethodCode = dr[1].ToString();
                    p.SalesTrID = dr[2].ToString();
                    p.Amount = Convert.ToInt32(dr[3].ToString());
                    p.Status = dr[4].ToString();                    
                }
                dr.Close();
                conn.getConnected.Close();
            }
            return p;
        }

        public void createOrder(SalesTransaction sales)
        {
            conn.getConnected.Open();
            //for SalesTransaction
            SqlCommand cmd = new SqlCommand(@"INSERT INTO SalesTransaction (SalesTrID, CustID, EmpID, DiscCode, Type, ManPrice, TotalPrice, DateCreated,TimeCreated,Status) 
                VALUES('" + sales.SalesTrID +
            "', '" + sales.Customer.CustID +
            "', '" + sales.EmpID +
            "','" + sales.DiscCode +
            "', '" + sales.Type +
            "', '" + sales.ManPrice +
            "', '" + sales.TotalPrice +
            //"', '" + DateTime.Now.ToString("MM/dd/yyy") +
            "', '" + sales.DateCreated.ToString("MM/dd/yyy") +
            //"', '" + DateTime.Now.ToString("HH:mm") +            
            "', '" + sales.TimeCreated.ToString("HH:mm") +
            "', '" + sales.Status +            
            "')", conn.getConnected);
            Console.WriteLine(sales.DateCreated.ToString("MM/dd/yyy"));
            Console.WriteLine(sales.TimeCreated.ToString("HH:mm"));
            cmd.ExecuteNonQuery();
            //for product
            foreach (Product pr in sales.Products)
            {
                SqlCommand cmd2 = new SqlCommand(@"INSERT INTO Product_inTransaction (ProductID, SalesTrID, Quantity) 
                VALUES('" + pr.ProductID +
            "', '" + sales.SalesTrID +
            "', '" + pr.Qty +            
            "')", conn.getConnected);
                cmd2.ExecuteNonQuery();
            }
            
            conn.getConnected.Close();
            //payment
            createPayment(sales.Payment);
            //delivery
            if (sales.Type == "Delivery") { createDelivery(sales.Delivery); }
            //point
            updatePoint(sales.Customer.CustID, sales.TotalPrice);
                    
        }

        public void createUser(Employee em)
        {
            conn.getConnected.Open();
            //Employee
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Employee (EmpID, FirstName, LastName, Role, Username, Password, DoB) 
                VALUES('" + em.EmpID +
            "', '" + em.FirstName +
            "', '" + em.LastName +
            "', '" + em.Role +
            "', '" + em.Username +
            "', '" + em.Password +
            "', '" + em.DoB.ToString("MM/dd/yyy") +          
            "')", conn.getConnected);          
            cmd.ExecuteNonQuery();            
            conn.getConnected.Close();           
        }

        public void DeleteUser(String ID)
        {
            conn.getConnected.Open();           
            SqlCommand cmd = new SqlCommand(@"Delete From Employee where EmpID='"+ID+"'  ", conn.getConnected);
            cmd.ExecuteNonQuery();
            conn.getConnected.Close();
        }

        public SalesTransaction loadOrder(String salesID)
        {
            conn.getConnected.Open();
            SalesTransaction p = new SalesTransaction();
            SqlCommand cmd = new SqlCommand(@"Select * From SalesTransaction Where SalesTrID like '" + salesID + "'", conn.getConnected);
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    p.SalesTrID = dr[0].ToString();
                    p.CustID = dr[1].ToString();
                    p.EmpID = dr[2].ToString();
                    p.DiscCode = dr[3].ToString();
                    p.Type = dr[4].ToString();
                    p.ManPrice = Convert.ToInt32(dr[5].ToString());
                    p.TotalPrice = Convert.ToInt32(dr[6].ToString());
                    p.DateCreated = Convert.ToDateTime(dr[7].ToString());
                    p.TimeCreated = Convert.ToDateTime(dr[8].ToString());
                    p.Status = dr[9].ToString();
                }
                dr.Close();
                conn.getConnected.Close();
            }
            //load customer
            p.Customer = loadCustomer(p.CustID);
            //load product purchased
            p.Products = loadProductPurchased(p.SalesTrID);
            //load payment
            p.Payment = loadPayment(p.SalesTrID);
            //load delivery
            if (p.Type == "Delivery") { p.Delivery = loadDelivery(p.SalesTrID); }

            return p;
        }

        public void loadOrder(DataGridView dataGridView1)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from SalesTransaction", conn.getConnected);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            List<SalesTransaction> AllSales = new List<SalesTransaction>();
            foreach (DataRow item in dt.Rows)
            {
                SalesTransaction sales = loadOrder(item[0].ToString());
                AllSales.Add(sales);
            }
            foreach (SalesTransaction cs in AllSales)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = cs.SalesTrID;
                dataGridView1.Rows[n].Cells[1].Value = cs.Customer.FirstName + " " + cs.Customer.LastName;
                dataGridView1.Rows[n].Cells[2].Value = cs.Type;
                dataGridView1.Rows[n].Cells[3].Value = cs.DateCreated.ToString("MM/dd/yyy");
                dataGridView1.Rows[n].Cells[4].Value = cs.TimeCreated.ToString("HH:mm");
                dataGridView1.Rows[n].Cells[5].Value = cs.TotalPrice;
                dataGridView1.Rows[n].Cells[6].Value = cs.Status;
            }            
        }

        public List<Product> loadProductPurchased(String SalesID)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Product_inTransaction Where SalesTrID like '" + SalesID + "'", conn.getConnected);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            List<Product> prods = new List<Product>();
            foreach (DataRow item in dt.Rows)
            {
                Product pr = loadProduct(item[0].ToString());
                pr.Qty = Convert.ToInt32(item[2].ToString());
                prods.Add(pr);
            }            
            return prods;
        }

        public String loadLatestPurchase(String CustID)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select SalesTransaction.SalesTrID, SalesTransaction.DateCreated, Customer.FirstName from SalesTransaction "+
"Inner join Customer on SalesTransaction.CustID = Customer.CustID where Customer.CustID = '"+CustID+"' order by SalesTransaction.DateCreated DESC", conn.getConnected);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            String n="";
            if (dt.Rows.Count != 0) {n += dt.Rows[0][1].ToString(); }
            else { n = "No purchase yet"; }
            
            return n;
        }

        public String loadSumSpent(String CustID)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select SUM(TotalPrice) from SalesTransaction  where SalesTransaction.CustID='"+CustID+"' ", conn.getConnected);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            String n = "";
            if (dt.Rows.Count != 0) { n += dt.Rows[0][0].ToString(); }
            else { n = "No purchase yet"; }

            return n;
        }

        public void updateOrderStatus(String salesID, String status)
        {
            conn.getConnected.Open();
            SqlCommand cmd = new SqlCommand("UPDATE SalesTransaction SET Status ='" + status +               
                "' WHERE (SalesTrID='" + salesID + "')", conn.getConnected);
            cmd.ExecuteNonQuery();
            conn.getConnected.Close();
        }

        public void updatePoint(String custID, int totalprice)
        {          
            int addpt = totalprice / 3000;       
            //get current point
            SqlDataAdapter sda = new SqlDataAdapter("select Point from Customer where CustID='" + custID + "' ", conn.getConnected);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int currentpt = Convert.ToInt32(dt.Rows[0][0].ToString());
            int newpt = addpt + currentpt;
            conn.getConnected.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Customer SET Point ='" + newpt +
                "' WHERE (CustID='" + custID + "')", conn.getConnected);
            cmd.ExecuteNonQuery();
            conn.getConnected.Close();
        }

        //function random for testing purpose
        public List<String> randomAddress()
        {
            List<String> fulladd = new List<string>();
            Random random = new Random();            
            var list = new List<string> { "Tanjungan Asri", "Graha Tanjungan Asri", "Wates Tanjung",
                "Taman Cendana Indah", "Kota Baru Driyorejo", "Gading Intan", "Graha Mutiara Indah",
                "Keputih Klagen", "Balong Bendo Indah", "Sumput Asri", "Pesona Bukit Tanjung",
                "Larangan", "Semambung", "Krikilan", "Kesamben",
                "Citraland", "Citra Harmoni" };
            var lista = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
            "K","L","M","N"};
            var subdis = new List<string> { "Tanjungan", "Wringinanom", "Driyorejo", "Sumput", "Mojosarirejo",
                "Randegansari", "Cangkir", "Tenaru", "Krikilan", "Banjaran",
            "Kesambenwetan","Karangandong","Petiken","Gadung","Bambe","Krian"};
            var distr = new List<string> { "Driyorejo", "Cerme", "Kedamean", "Menganti", "Kebomas",
                "Wringinanom", "Benjeng", "Balongpanggang","Krian"};
            var post = new List<string> { "61178", "61177","61179"};

            int index = random.Next(list.Count);
                int n1 = random.Next(1, 21);
                int n2 = random.Next(1, 41);            
                int indexa = random.Next(lista.Count);
                int s = random.Next(subdis.Count);
                int d = random.Next(distr.Count);
                int ps = random.Next(post.Count);
            String address = "Perumahan " + list[index] + " Block " + lista[indexa] + n1.ToString() + " No. " + n2.ToString();
                Console.WriteLine(address);

            fulladd.Add("HOME") ;
            fulladd.Add(address);
            if (index == 1 || index == 2 || index == 1) { fulladd.Add("TANJUNGAN"); }
            else { fulladd.Add(subdis[s].ToUpper()); }
            fulladd.Add(distr[d].ToUpper());
            fulladd.Add("GRESIK");
            fulladd.Add("EAST JAVA");
            fulladd.Add(post[ps]);
            
            
            
            return fulladd;

        }

        public List<String> randomCust()
        {
            Random random = new Random();
            List<String> fullcus = new List<string>();
            var first = new List<string> { "VEY EVELYN", "DERY", "ISKANDAR",
                "NUR", "DIKA", "JAKA", "SUSAN",
                "GALUH", "EDDY", "MUHAMMAD", "DEDY",
                "HERDIANA", "AVININDA", "NERI", "YOGA",
                "YUSUF NUR", "FILIA NERI","ANNISA","NOVITA","PARDEDE","JUNICHO"
            ,"MARIO","ELY","NI KOMANG","RACHMITA","OKI","NURDHITO","AJI"
            ,"DEWI","MUHAMMAD","JUNAEDY","YUNI","ASMARANTI","PEBRI","SUSANTI","FITRIANA"
            ,"DEDY","MUHAMMAD","ANGGRAENI","HARTISNING","RINA","OKTAVIANI","DINA","DWILESTARI"
            ,"ALFIN","MUHAMMAD","MAULIDA","PERWITA","MARIYAH","LILIS","ULFAH","SIREGAR"
            ,"TAMBOK","GERHANITA","JUNINGSIH","ANNISA","SHANTI","MARLINA","JAQUALINE","AMANDA"
            ,"YAKOB","MUHAMMAD","MUHAMMAD","MUHAMMAD","MUHAMMAD","MUHAMMAD","MUHAMMAD","MUHAMMAD"
            ,"STIEN","YAKOB","RUMBINO","PRISCHILLA","AYEMI","DWIARTHO","BERMAN","GUNADI"
            ,"FEBBY","NITA","MANGALIK","TALINTIN","KUSUMANINGRUM","INDRI","HARLINA","SUWANDY"};
            var last = new List<string> { "SINAGA", "ABDURACHIM", "ADLINA",
                "AISYAH", "SEKAR", "OCTINA", "PUTRO",
                "ASIYANTI", "QALISHA", "HANNY",
                "AMINULLAH", "BARA", "PRATOMO", "PUSPITA",
                "ANGGRI","YOGO","WIDAGDO","HAIRUN","NISSA","TARAKANITA","NASTITI","ANGGA"
            ,"DITA","MAYA","SARI","TASNIM","MAULANA","FAJAR","TUBAGUS","SATYA"
            ,"RIRI","PRIHAYATI","PERTIWI","ANGGITA","SABRINA","RATNA","KURNIA","SANTI"
            ,"SARI","DESWINA","DWI","HAYANTI","MEGA","MAHARDIKA","NARWANTO","SEKAR"
            ,"WAHYU","PERDANA","ARIF","FATHURAHMAN","RANI","PUTI","MELINDA","DYAH"
            ,"AFIFAH","MELINDA","KATAN","TAPUN","WAHYU","FAJAR","RAMADHAN","JUARISANTO",
                "ELEDORA", "SONDRA" };
            int day = random.Next(1, 32);
            int month = random.Next(1, 13);
            int year = random.Next(1969, 1997);
            int phone = random.Next(99999999, 1000000000);
            var mail = new List<string> { "@gmail.com", "@yahoo.com", "@hotmail.com"};
            var occ = new List<string> { "BUSINESSMAN", "EMPLOYEE", "STUDENT", "OTHER" };

            int ran1 = random.Next(first.Count);
            int ran2 = random.Next(last.Count);
            int ran3 = random.Next(mail.Count);
            int ran4 = random.Next(occ.Count);
            String dob = month.ToString() + "/" + day.ToString() + "/" + year.ToString();

            fullcus.Add(first[ran1]);
            fullcus.Add(last[ran2]);
            fullcus.Add(dob);
            fullcus.Add("08" +phone.ToString());
            fullcus.Add(first[ran1]+mail[ran3]);
            fullcus.Add(occ[ran4]);
            return fullcus;
        }

        public bool isExist(String feature, String value)
        {
            bool exist = false;
            DataTable dt = new DataTable();
            if (feature == "FirstName")
            {
                SqlDataAdapter sda = new SqlDataAdapter("select FirstName from Customer where FirstName='" + value + "' ", conn.getConnected);                
                sda.Fill(dt);
            }
            if (feature == "LastName")
            {
                SqlDataAdapter sda = new SqlDataAdapter("select LastName from Customer where LastName='" + value + "' ", conn.getConnected);
                sda.Fill(dt);
            }
            int n = dt.Rows.Count;
            if (n!=0)
            {
                exist = true;
            }
            
            return exist;
        }
        //end
        public void searchCustomer(DataGridView dgv, TextBox textbox)
        {
            conn.getConnected.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Customer Where (CustID like '%" + textbox.Text + "%') "
                +"or(FirstName like '%" + textbox.Text + "%') or(LastName like '%" + textbox.Text + "%') "
                +"or(Email like '%" + textbox.Text + "%') or(Phone like '%" + textbox.Text + "%') or"
                +"(Occupation like '%" + textbox.Text + "%') ", conn.getConnected);           
            DataTable dt = new DataTable();
            sda.Fill(dt);
            List<Customer> cuss = new List<Customer>();
            foreach (DataRow item in dt.Rows){
                Customer cus = new Customer();
                cus.CustID = item[0].ToString();
                cus.FirstName = item[1].ToString();
                cus.LastName = item[2].ToString();
                cus.DoB = Convert.ToDateTime(item[3]);
                cus.Phone = item[4].ToString();
                cus.Email = item[5].ToString();
                cus.Occupation = item[6].ToString();
                cus.Point = Convert.ToInt32(item[7].ToString());
                cus.RegistrationDate = Convert.ToDateTime(item[8]);
                cuss.Add(cus);
            }
            dgv.Rows.Clear();
            foreach (Customer cs in cuss){
                int n = dgv.Rows.Add();
                dgv.Rows[n].Cells[0].Value = cs.CustID;
                dgv.Rows[n].Cells[1].Value = cs.FirstName + " " + cs.LastName;
                dgv.Rows[n].Cells[2].Value = cs.RegistrationDate.ToString();
                dgv.Rows[n].Cells[3].Value = loadLatestPurchase(cs.CustID);
            }
            conn.getConnected.Close();
        }
    }



    
}
