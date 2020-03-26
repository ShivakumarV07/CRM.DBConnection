using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.DBConnection.Web.Models
{
    public partial class User
    {
     

        public int UserID { get; set; }
        public Nullable<int> DomainId { get; set; }
        public int SocketId { get; set; }
        public string UsrName { get; set; }
        public string Password { get; set; }
        public int DefaultSite { get; set; }
        public Nullable<int> SelectedSite { get; set; }
        public string SelectedDatabase { get; set; }
        public string SelectedServer { get; set; }
        public bool tiActive { get; set; }
        public Nullable<int> iExtraUserId1 { get; set; }
        public string vchExtraPassword1 { get; set; }
        public string vchSessionId1 { get; set; }
        public Nullable<int> iNumberOfAttempts { get; set; }
        public Nullable<System.DateTime> dtLastAttempt { get; set; }
        public Nullable<byte> tiUserAgreement { get; set; }
        public Nullable<byte> iALLipAccess { get; set; }
        public Nullable<System.DateTime> dtChangePassword { get; set; }
        public string vchRequirePasswordChange { get; set; }
        public Nullable<System.DateTime> dtUserAgreementAcceptDate { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Nullable<byte> allipAccessMobile { get; set; }
        public byte ContractAdminPermission { get; set; }
        public Nullable<bool> tiContractAdmin { get; set; }
        public string SalesForceUserType { get; set; }
        public DateTime? LastSecurityUpdate { get; set; }

    }
}
