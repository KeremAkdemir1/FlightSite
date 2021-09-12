using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VacationSite3.Models.Data
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-8PLNS1VS;database=VacationDb4;integrated security=true");
        }
        public DbSet<Flights> Flight { get; set; }
        public DbSet<Countries> Country { get; set; }
        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
