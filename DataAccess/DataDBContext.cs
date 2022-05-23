
using HamserWarsApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataDBContext : DbContext
    {
        public DbSet<Hamster> Hamsters { get; set; }

        public DataDBContext(DbContextOptions<DataDBContext> options) : base(options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
            
            

        //}

    }
}
