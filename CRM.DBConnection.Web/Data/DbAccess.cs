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

        public DbAccess(DirectorContext context)
        {
            _context = context;
        }
        
        public string RetrieveConnectStr(int siteId)
        {
            try
            {
                var siteInfo = _context.Sites.FirstOrDefault(s => s.SiteId == siteId);
                //string connString = Configuration["siteConn"].ToString();
                //string connString = ConfigurationManager.AppSettings["siteConn"].ToString();
                string connString = "Server=LT50030\\MSSQLSITES;Database={database};Trusted_Connection=True;MultipleActiveResultSets=true";
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
