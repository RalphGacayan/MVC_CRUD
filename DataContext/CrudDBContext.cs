using Microsoft.EntityFrameworkCore;
using MyMVC_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVC_CRUD.DataContext
{
    public class CrudDBContext : DbContext 
    {
        public CrudDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
