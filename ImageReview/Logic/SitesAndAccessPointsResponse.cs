using System.Collections.Generic;

namespace ImageReview.Logic
{
    public class Location
    {
        public int id { get; set; }
        public string name { get; set; }
        public int active { get; set; }
        public List<AccessPoint> gates { get; set; }
    }

    public class AccessPoint
    {
        public int id { get; set; }
        public int locationID { get; set; }
        public string locationName { get; set; }
        public string name { get; set; }
        public string AccessPointIDName { get; set; }
        public int is_exit { get; set; }
    }

    public class SitesAndAccessPointsResponse
    {
        public List<Location> data { get; set; }
        public bool status { get; set; }
    }
}
