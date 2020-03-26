using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRM.DBConnection.Web.Models;

namespace CRM.DBConnection.Web.Data
{
    public class CampaignsContext : DbContext
    {
        public CampaignsContext (DbContextOptions<CampaignsContext> options)
            : base(options)
        {
        }
        //public CampaignsContext(string connString) : base(connString)
        //{

        //}
        public DbSet<Campaign> Campaign { get; set; }
    }
}
