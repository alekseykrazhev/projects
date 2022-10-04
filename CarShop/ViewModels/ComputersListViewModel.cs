using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class ComputersListViewModel
    {
        public IEnumerable<Computer> allComputers { get; set; }
        public string computerCategory { get; set; }
    }
}
