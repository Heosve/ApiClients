﻿using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;


namespace WebApplication1.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options): base(options)
        {
            
        }

        public DbSet<Client> Clients { get; set; }
    }
}
