using Microsoft.EntityFrameworkCore;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class AppDBContent : DbContext //Control Data
    {

        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {
           
        }

        public DbSet<Computer> Computer { get; set; }
        public DbSet<Category> Category { get; set; }

    }
}
