using EFCore_Introducao.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_Introducao
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(
                @"Server=.;Database=EFCore;Integrated Security=True");
        }
    }
}
