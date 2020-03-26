using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.DBConnection.Web.Models
{
    public class UserInfo
    {
        public int? SelectedSite { get; set; }
        public int DefaultSite { get; set; }
        public int UserId { get; set; }
        public string SessionIdWc { get; set; }
        public int? WcUserId { get; set; }
        public string Branding { get; set; }
        public string Password { get; set; }
    }
}
