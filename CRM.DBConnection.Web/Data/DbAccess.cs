using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.DBConnection.Web.Data
{
    public class DbAccess
    {
        private readonly DirectorContext _context;
        private IConfiguration _config;

        public DbAccess(DirectorContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }
        
        public string RetrieveConnectStr(int siteId)
        {
            try
            {
                var siteInfo = _context.Sites.FirstOrDefault(s => s.SiteId == siteId);
                string connString = _config.GetConnectionString("siteConn");
                connString = connString.Replace("{server}", siteInfo.SqlServerNetworkName);
                connString = connString.Replace("{database}", siteInfo.DatabaseName);
                return connString;
            }
            catch (Exception)
            {
                return null;
            }

        }
        
    }
}
