using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class ComputerRepository : IAllComputers
    {
        private readonly AppDBContent appDBContent;

        public ComputerRepository(AppDBContent appDBContent) {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Computer> Computers => appDBContent.Computer.Include(c => c.Category); // take all object

        public IEnumerable<Computer> getFavComputers => appDBContent.Computer.Where(p => p.isFavourite).Include(c => c.Category); // take object with parametr "isFavourite == true"

        public Computer getObjectComputer(int computerId) => appDBContent.Computer.FirstOrDefault(p => p.id == computerId); // take object with "id == carId"
    }
}
