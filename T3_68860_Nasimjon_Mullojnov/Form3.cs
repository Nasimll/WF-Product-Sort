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
    public partial class Form3 : Form
    {
        List<Product> products = new List<Product>();
        public Form3()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;
            if (path != null)
            {
                ReadCreateP(path);
                NamesAdd();

            }
        }

        private void ReadCreateP(string path)
        {
            products.Clear();

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string line;

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                Product p = new Product(line);
                products.Add(p);

            }


            sr.Close();
            fs.Close();
        }

        private void NamesAdd()
        {
            listBox1.Items.Clear();

            for (int i = 0; i < products.Count; i++)
            {
                listBox1.Items.Add($"{products[i].id}   {products[i].name}   {products[i].brand}   {products[i].price}$");

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }
    }
}
