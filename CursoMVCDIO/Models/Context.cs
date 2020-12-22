﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVCDIO.Models
{
    public class Context: DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOtionsBuilder)
        {

            dbContextOtionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Cursomvc;Integrated Security =True;User id=grupotcm;Password=22gatsu12ka92");

        }


    }
}
