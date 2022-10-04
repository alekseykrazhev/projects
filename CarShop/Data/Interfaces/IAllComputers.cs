using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Interfaces
{
    public interface IAllComputers
    {
        IEnumerable<Computer> Computers { get; } // return all products
        IEnumerable<Computer> getFavComputers { get; } // return favourits products
        Computer getObjectComputer(int carId); // retunt product with using id
    }
}
