using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.DBConnection.Web.Models
{
    public partial class UserRole
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public int SiteId { get; set; }
        public Nullable<int> AddressId { get; set; }
        public Nullable<int> MgrId { get; set; }
        public Nullable<bool> tiActive { get; set; }
        public string vchExternalId { get; set; }
        public string vchInternalPhoneId { get; set; }
        public string vchExternalPhoneId { get; set; }
        public Nullable<bool> tiShowAssigned { get; set; }
        public int iUserRoleId { get; set; }
        public string vchExternalPhoneId2 { get; set; }
        public string chInsertBy { get; set; }
        public Nullable<System.DateTime> dtInsertDate { get; set; }
        public string chUpdateBy { get; set; }
        public Nullable<System.DateTime> dtUpdateDate { get; set; }
        public string vchEmail { get; set; }
        public Nullable<int> iOutBoundPhoneRouting { get; set; }
        public byte[] tsFireSocket { get; set; }
    }
}
