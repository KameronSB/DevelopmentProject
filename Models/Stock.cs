using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Irish_Woollens_co_operative_e_commerce.Models
{
    public class Stock
    {

        //fields
        private int product_Id
        {
            get { return product_Id; }
            set { product_Id = value; }
        }

        private String name
        {
            get { return name; }
            set { name = value; }
        }

        private String description
        {
            get { return description; }
            set { description = value; }
        }

        private int price
        {
            get { return price;  }
            set { price = value; }
        }

        //constructor
        public Stock(int id, String Name, String Description, int Price)
        {
            product_Id = id;
            name = Name;
            description = Description;
            price = Price;
        }

        //methods

    }
}
