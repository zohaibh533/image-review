using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageReview.Logic
{
    public class LoginResponce
    {
        public string access_point_id { get; set; }
        public string login { get; set; }
        public string default_ratemaster_id { get; set; }
        public string name { get; set; }
        public string usertype { get; set; }
        public string open_barrier { get; set; }
        public string dispute_enabled { get; set; }
        public string trn { get; set; }
        public string address { get; set; }
        public string vat_company_name { get; set; }
    }

    public class LoginResponce_Root
    {
        public List<LoginResponce> Result { get; set; }
    }

    public class CloseTrip_Responce
    {
        public string message { get; set; }
        public string status { get; set; }
    }

    public class Reason
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
