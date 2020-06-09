using Microsoft.EntityFrameworkCore;
using RazorApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorApplication.Services
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
