using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Interfaces
{
    public interface IComputersCategory
    {
        IEnumerable<Category> AllCategories { get; } // only get all from Category
    }
}
