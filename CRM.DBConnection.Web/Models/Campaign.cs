using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.DBConnection.Web.Models
{
    public partial class Campaign
    {
        [Key]
        public int iCampaignId { get; set; }
        public int iSiteId { get; set; }
        public int iCampaignTypeId { get; set; }
        public string chTrackingCode { get; set; }
        public string vchCampaignName { get; set; }
        public Nullable<int> iStatusId { get; set; }
        public Nullable<int> iEventCategory { get; set; }
        public Nullable<System.DateTime> dtStartDate { get; set; }
        public Nullable<System.DateTime> dtEndDate { get; set; }
        public string vchObjectives { get; set; }
        public string chInsertBy { get; set; }
        public System.DateTime dtInsertDate { get; set; }
        public string chUpdateBy { get; set; }
        public System.DateTime dtUpdateDate { get; set; }
        public byte tiRecordStatus { get; set; }
        [Timestamp]
        public byte[] tsFireSocket { get; set; }
        public Nullable<int> iEventStopStatus { get; set; }
        public Nullable<byte> tiDisplay { get; set; }
        public Nullable<int> tiCancelable { get; set; }
        public Nullable<byte> tiCancelOnVehicleDelivery { get; set; }
        public Nullable<byte> tiShowInCampaignROI { get; set; }
        public Nullable<int> MarketingChannelId { get; set; }
        public Nullable<int> SmartWorkPlansiRefDefinitionId { get; set; }

        public Nullable<int> MarketingTypeId { get; set; }
        public Nullable<bool> DisplayInSalesEvent { get; set; }
    }
}
