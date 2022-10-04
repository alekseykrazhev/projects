using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockComputers : IAllComputers
    {

        private readonly IComputersCategory _categoryComputers = new MockCategory();

        public IEnumerable<Computer> Computers
        {
            get
            {
                return new List<Computer>
                {
                    new Computer{
                        name = "Macbook Air",
                        shortDesc = "Power. It's in the Air",
                        longDesc = "With the longest range and quickest acceleration of any electric vehicle in production.",
                        img = "/img/macbook-air.jpeg",
                        price = 1200,
                        isFavourite = true,
                        available = true,
                        Category = _categoryComputers.AllCategories.First()
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
                        Category = _categoryComputers.AllCategories.First()
                    }
                    //,

                    //new Computer
                    //{
                    //    name = "1970",
                    //    shortDesc = "Back to the Future.",
                    //    longDesc = "Classic American muscle car - the perfect solution for the soul.",
                    //    img = "/img/mustang.jpg",
                    //    price = 32000,
                    //    isFavourite = true,
                    //    available = true,
                    //    Category = _categoryComputers.AllCategories.Last()
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
                    //    Category = _categoryComputers.AllCategories.Last()
                    //}
                };
            }
        }
        public IEnumerable<Computer> getFavComputers { get; set; }

        public Computer getObjectComputer(int computerId)
        {
            throw new NotImplementedException();
        }
    }
}
