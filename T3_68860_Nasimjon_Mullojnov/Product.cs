using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_68860_Nasimjon_Mullojnov
{
     class Product
    {
        public string name, brand, id;
        public int price;

        /// <summary>
        /// COnstructor for the Product object ion files.
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="brand">Brand</param>
        /// <param name="price">Price</param>
        public Product(string name, string brand, int price)
        {
            this.name = name;
            this.brand = brand;
            this.price = price;
            this.id = getID();
        }

        /// <summary>
        /// New constructor for the data
        /// </summary>
        /// <param name="data">Returns string</param>
        public Product(string data)
        {
            string[] spliteddata = data.Split('@');
            this.name = spliteddata[0];
            this.brand = spliteddata[1];
            this.price = Convert.ToInt32(spliteddata[2]);
            this.id = spliteddata[3];

        }

        /// <summary>
        /// Creates random Id number for each product
        /// </summary>
        /// <returns>string of ID</returns>
        private string getID()
        {
            Random rnd = new Random();
            int rand = rnd.Next(1000, 10000);
            return $"{name[0]}{name[1]}_{rand}";
        }


        /// <summary>
        /// Code to write get data of the product and put it on  file
        /// </summary>
        /// <returns>the string for the file to put on</returns>
        public string getData()
        {
            return $"{name}@{brand}@{price}@{id}";
        }
    }
}
