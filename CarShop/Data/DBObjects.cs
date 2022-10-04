using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content) {
            

            if (!content.Category.Any()) // check for null
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Computer.Any())
            {
                content.AddRange(
                    new Computer
                    {
                        name = "Macbook Air",
                        shortDesc = "Power. It's in the Air",
                        longDesc = "With the longest range and quickest acceleration of any electric vehicle in production.",
                        img = "/img/macbook-air.jpeg",
                        price = 1200,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Ноутбуки"]
                    },

                    new Computer
                    {
                        name = "iMac",
                        shortDesc = "You can do a lot with your Mac",
                        longDesc = "Born Apple. Endowed with the power of the M1 chip. Stands out against any background. Fits perfectly into your life.",
                        img = "/img/imac.jpg",
                        price = 2500,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Компьютеры"]
                    }
                    //,

                    //new Computer
                    //{
                    //    name = "Ford Mustang 1970",
                    //    shortDesc = "Back to the Future.",
                    //    longDesc = "Classic American muscle car - the perfect solution for the soul.",
                    //    img = "/img/mustang.jpg",
                    //    price = 32000,
                    //    isFavourite = true,
                    //    available = true,
                    //    Category = Categories["Автомобили с ДВС"]
                    //},

                    //new Computer
                    //{
                    //    name = "Mercedes-Benz s63",
                    //    shortDesc = "Sonic endorphin machine.",
                    //    longDesc = "The interior of this car has been developed over the years for your comfort.",
                    //    img = "/img/MBS63.jpg",
                    //    price = 35000,
                    //    isFavourite = true,
                    //    available = false,
                    //    Category = Categories["Автомобили с ДВС"]
                    //}
                );
            }

            content.SaveChanges();

        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category{ categoryName = "Компьютеры", desc = "Стационарные компьютеры"},
                        new Category{ categoryName = "Ноутбуки", desc = "Переносные компьютеры"}
                    };

                    category = new Dictionary<string, Category>();
                    // add element from list
                    foreach(Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }

                return category;
            }
        }
    }
}
