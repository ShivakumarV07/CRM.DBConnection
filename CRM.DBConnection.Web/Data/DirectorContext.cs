using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRM.DBConnection.Web.Models;

namespace CRM.DBConnection.Web.Data
{
    public class DirectorContext : DbContext
    {
        public DirectorContext (DbContextOptions<DirectorContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Site> Sites { get; set; }
    }
}
