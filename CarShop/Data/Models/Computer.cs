using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Computer
    {
        public int id { get; set; } // product id
        public string name { get; set; } // product name
        public string shortDesc { get; set; } // short description of goods
        public string longDesc { get; set; } // long description of goods
        public string img { get; set; } // product img
        public ushort price { get; set; } // product price
        public bool isFavourite { get; set; } // if "isfavourite == true" ==> product is visible on the main page in block "Favourite product"
        public bool available { get; set; } // is there a product in stock
        public int categoryID { get; set; } // specific category number
        public virtual Category Category { get; set; } // object of a certain category

    }
}
