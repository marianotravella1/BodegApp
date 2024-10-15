﻿using BodegApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BodegApp.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Wine> Wines { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        {
            
        }
    }
}