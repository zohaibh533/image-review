using System;
using System.Collections.Generic;
using System.ComponentModel;
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

    public class ReportType
    {
        public string Code { get; set; }
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

        public int TriggerType { get; set; }
        public int IsBackWard { get; set; }
        public string Direction { get; set; }
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
        public int LocationID { get; set; }
        public string AccessPointName { get; set; }
        public int NoOfTrigger { get; set; }
        public string ids { get; set; }
    }

    public class MasterParkonicData
    {
        public string event_time { get; set; }
        public long transaction_id { get; set; }
        public int location_id { get; set; }
        public int access_point_id { get; set; }
        public int is_exit { get; set; }
        public double bill_amount { get; set; }
        public string plate_code { get; set; }
        public string plate_number { get; set; }
        public string emirates { get; set; }
        public int trigger_type { get; set; }
    }

    public class SortableBindingList<T> : BindingList<T>
    {
        private bool _isSorted;
        private ListSortDirection _sortDirection;
        private PropertyDescriptor _sortProperty;

        public SortableBindingList() : base() { }

        public SortableBindingList(IList<T> list) : base(list) { }

        protected override bool SupportsSortingCore => true;
        protected override bool IsSortedCore => _isSorted;
        protected override PropertyDescriptor SortPropertyCore => _sortProperty;
        protected override ListSortDirection SortDirectionCore => _sortDirection;

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            var items = (List<T>)Items;
            var propInfo = typeof(T).GetProperty(prop.Name);
            if (propInfo != null)
            {
                items.Sort((x, y) =>
                {
                    var xValue = propInfo.GetValue(x);
                    var yValue = propInfo.GetValue(y);
                    return direction == ListSortDirection.Ascending
                        ? Comparer<object>.Default.Compare(xValue, yValue)
                        : Comparer<object>.Default.Compare(yValue, xValue);
                });

                _isSorted = true;
                _sortDirection = direction;
                _sortProperty = prop;
                OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
            }
        }

        protected override void RemoveSortCore()
        {
            _isSorted = false;
        }
    }
}
