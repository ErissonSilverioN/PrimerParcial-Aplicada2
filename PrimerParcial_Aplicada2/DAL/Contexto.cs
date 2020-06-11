﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial_Aplicada2.DAL
{
    public class Contexto : DbContext
    {
        //public DbSet<> MyProperty { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= C:\Users\PANDA\source\repos\PrimerParcial_Aplicada2\PrimerParcial_Aplicada2\DataBase\ParcialDB.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}