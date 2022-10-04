using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockCategory : IComputersCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category> { 
                    new Category{ categoryName = "Компьютеры", desc = "Стационарные компьютеры"},
                    new Category{ categoryName = "Ноутбуки", desc = "Переносные компьютеры"}
                };
            }
        }
    }
}
