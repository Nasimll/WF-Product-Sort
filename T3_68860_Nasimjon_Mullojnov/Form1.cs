using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T3_68860_Nasimjon_Mullojnov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product p = NewProduct();
            writeProduct(p);

            tbPname.Text = string.Empty;
            tbPbrand.Text = string.Empty;
            tbPprice.Text = string.Empty;
            lblId.Text = "#";

        }

        /// <summary>
        /// Write the Product as a string on a file
        /// </summary>
        /// <param name="p">Product object .</param>
        private void writeProduct(Product p)
        {
            FileStream fs = new FileStream("dataFile.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(p.getData());

            sw.Close();
            fs.Close();
        }
        /// <summary>
        /// Create a Product object from user input data textbox
        /// </summary>
        /// <returns>The product Object</returns>
        private Product NewProduct()
        {
            return new Product(tbPname.Text, tbPbrand.Text, Convert.ToInt32(tbPprice.Text));
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close();

        }
    }
}
