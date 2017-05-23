﻿using System.Data.Entity;

namespace Domain
{
    public class DataContext : DbContext 
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Domain.Rutina> Rutinas { get; set; }
    }
}
