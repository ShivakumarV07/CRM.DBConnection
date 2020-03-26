using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.DBConnection.Web.Models
{
    [Table("SiteDatabaseDealershipSqlServer")]
    public class Site
    {
        public string SiteName { get; set; }
        public string DatabaseName { get; set; }
        public string SqlServerNetworkName { get; set; }
        public int SiteId { get; set; }
    }
}
