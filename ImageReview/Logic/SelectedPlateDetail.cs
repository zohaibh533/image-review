using System.Collections.Generic;

namespace ImageReview.Logic
{
    public class Anpr
    {
        public string category { get; set; }
        public string text { get; set; }
        public string country { get; set; }
        public string country_code { get; set; }
        public string confidence { get; set; }
        public string plate_image { get; set; }
        public string frame_image { get; set; }
        public string camer_ip { get; set; }
        public string message { get; set; }
    }

    public class CharacterConfidence
    {
        public string character { get; set; }
        public int confidence { get; set; }
    }

    public class Correction
    {
        public Anpr anpr { get; set; }
        public List<CharacterConfidence> character_confidence { get; set; }
        public List<string> files_list { get; set; }
        public string folder_name { get; set; }
        public string location { get; set; }
        public string access_point_id { get; set; }
        public string entrance_Name { get; set; }
        public string transactionid { get; set; }
        public string event_datetime { get; set; }
        public string Server_ip { get; set; }
        public int is_exit { get; set; }
        public int location_id { get; set; }
        public string spot_number { get; set; }
    }

    public class SelectedPlateDetail
    {
        public Correction correction { get; set; }
    }

    public class PlateCorrectResponce
    {
        public string message { get; set; }
        public bool status { get; set; }
    }

    public class PlateActiveTripDetail
    {
        public ActiveTripData data { get; set; }
        public bool status { get; set; }
    }

    public class ActiveTripData
    {
        public string entry_time { get; set; }
        public string entry_gate { get; set; }
        public string location { get; set; }
    }


    public class RecentPlate
    {
        public string plate_code { get; set; }
        public string plate_number { get; set; }
        public string emirates { get; set; }
        public string time { get; set; }
        public string image { get; set; }
        public string trip_id { get; set; }
    }

    public class RecentPlates
    {
        public List<RecentPlate> data { get; set; }
        public bool status { get; set; }
    }

    public class ReplacePlateResponce
    {
        public string message { get; set; }
        public bool status { get; set; }
    }
}
