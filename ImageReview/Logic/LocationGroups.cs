using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageReview.Logic
{
    public class LocationGroups
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class GroupDetails
    {
        public int GroupID { get; set; }
        public int LocationID { get; set; }
    }

    public class LoginIDAndUserCount
    {
        public int LoginID { get; set; }
        public int UsersCount { get; set; }
    }

    public class CorrectionLog
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string UserRemarks { get; set; }
        public int ActionType { get; set; }
        public int LoginID { get; set; }
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public int AccessPointID { get; set; }
        public string AccessPointName { get; set; }
        public int IsExit { get; set; }
        public string TransactionID { get; set; }
        public string EventDateTime { get; set; }
        public string CapturedCode { get; set; }
        public string CapturedPlateNo { get; set; }
        public string CapturedCity { get; set; }
        public string CorrectedCode { get; set; }
        public string CorrectedPlateNo { get; set; }
        public string CorrectedCity { get; set; }
        public string ANPRMsg { get; set; }
        public string FolderName { get; set; }
        public string PlateReadTime { get; set; }
        public int ReasonID { get; set; }
        public string UserName { get; set; }
    }

    public enum ActionMaster
    {
        Correction = 1,
        Ignored = 2,
        Forwarded = 3,
        ExitPlates = 4,
        IgnoredAP = 5
    }

    public class FalseTrigger
    {
        public string EventDate { get; set; }
        public int AccessPointID { get; set; }

        public string FolderName { get; set; }
        public string LocationName { get; set; }
        public string AccessPointName { get; set; }
        public int NoOfTrigger { get; set; }
    }

}
