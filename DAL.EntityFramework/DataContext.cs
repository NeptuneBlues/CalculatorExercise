using DAL.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EntityFramework
{
    public class DataContext : DbContext
    {
        public DbSet<Calculation> Calculations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Data Source=Dev-SDJ;Initial Catalog=CalculatorPrototype_EF;Integrated Security=True");
    }
}
