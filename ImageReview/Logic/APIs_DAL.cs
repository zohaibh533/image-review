using RestSharp;
using System;
using System.Net;
using System.Threading.Tasks;

namespace ImageReview.Logic
{
    public static class APIs_DAL
    {
        public static async Task<IRestResponse> CorrectPlateNoAWS(string TransID, int AccessPointID,
          string PlateCode, string PlateNo, string PlateCity, string eventDate, int IsException,
          string _Remarks, string _spotNo)
        {
            try
            {
                var client = new RestClient("https://api.parkonic.com/");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                var request = new RestRequest("api/corrected-plate-data", Method.POST, DataFormat.Json);
                request.AddHeader("Accept", "application/json");
                request.AddJsonBody(new
                {
                    transaction_id = TransID,
                    access_point_id = AccessPointID,
                    plate_code = PlateCode,
                    plate_number = PlateNo,
                    emirates = PlateCity,
                    time = eventDate,
                    id = 0,
                    is_exit = 1,
                    is_exception = IsException,
                    remarks = _Remarks,
                    correction_user = Utilis.UserName,
                    spot_number = _spotNo,
                    is_verified = 1
                });

                return await client.ExecuteAsync(request);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static string awsToken = "fE7AP9UgZ0eAdIISZGtDP1cML";
        public static async Task<IRestResponse> GetSitesAndAccessPoints()
        {
            try
            {
                RestRequest req = new RestRequest("api/info/locations", Method.POST, DataFormat.Json);
                req.AddHeader("Accept", "application/json");
                req.AddJsonBody(new
                {
                    token = awsToken
                });

                RestClient restC = new RestClient("https://api.parkonic.com/");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                return await restC.ExecuteAsync(req);
            }
            catch (Exception ee)
            {
                throw ee;
            }
        }

        public static async Task<IRestResponse> GetRecentPlatesResponce(string apID, string eventTime)
        {
            try
            {
                RestRequest req = new RestRequest("api/plate-correction/recent-plates", Method.POST, DataFormat.Json);
                req.AddHeader("Accept", "application/json");
                req.AddJsonBody(new
                {
                    //token = awsToken
                    access_point_id = apID,
                    time = eventTime
                });

                RestClient restC = new RestClient("https://api.parkonic.com/");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                return await restC.ExecuteAsync(req);
            }
            catch (Exception ee)
            {
                throw ee;
            }
        }

        //public static Task<IRestResponse> ReplaceTrip(string TripID, string code, string PlateNo, string city, string user)
        //{
        //    return Task.Run(() =>
        //    {
        //        try
        //        {
        //            RestRequest req = new RestRequest("api/plate-correction/replace-plate", Method.POST, DataFormat.Json);
        //            req.AddHeader("Accept", "application/json");
        //            req.AddJsonBody(new
        //            {
        //                trip_id = TripID,
        //                plate_code = code,
        //                plate_number = PlateNo,
        //                emirates = city,
        //                correction_user = user,
        //                is_exception = 0
        //            });

        //            RestClient restC = new RestClient("https://api.parkonic.com/");
        //            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        //            return restC.Execute(req);
        //        }
        //        catch (Exception ee)
        //        {
        //            throw ee;
        //        }
        //    });
        //}

        //public static Task<IRestResponse> PlateCorrectionNotification()
        //{
        //    return Task.Run(() =>
        //    {
        //        try
        //        {
        //            RestRequest req = new RestRequest("api/info/plate-correction-notification", Method.POST, DataFormat.Json);
        //            req.AddHeader("Accept", "application/json");
        //            req.AddJsonBody(new
        //            {
        //                token = awsToken
        //            });

        //            RestClient restC = new RestClient("https://api.parkonic.com/");
        //            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        //            return restC.Execute(req);
        //        }
        //        catch (Exception ee)
        //        {
        //            throw ee;
        //        }
        //    });
        //}

        public static async Task<IRestResponse> GetPlateActiveTripDetail(string PlateCode, string PlateNo, string PlateCity)
        {
            try
            {
                RestRequest req = new RestRequest("api/info/active-trip", Method.POST, DataFormat.Json);
                req.AddHeader("Accept", "application/json");
                req.AddJsonBody(new
                {
                    token = awsToken,
                    plate_code = PlateCode,
                    plate_number = PlateNo,
                    emirates = PlateCity
                });

                RestClient restC = new RestClient("https://api.parkonic.com/");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                return await restC.ExecuteAsync(req);
            }
            catch (Exception ee)
            {
                throw ee;
            }
        }

        public static async Task<IRestResponse> SaveDataInMasterParkonic(MasterParkonicData trp)
        {
            try
            {
                RestRequest req = new RestRequest("api/verification-trip", Method.POST, DataFormat.Json);
                req.AddHeader("Accept", "application/json");//
                req.AddHeader("Authorization", "Bearer pBMjLJIRNQJA93a9691JfxavKO7GuaJkExaWZOye6HVwukfXNUFk4J2Fji3jR9br");
                req.AddJsonBody(new
                {
                    event_time = trp.event_time,
                    transaction_id = trp.transaction_id,
                    location_id = trp.location_id,
                    access_point_id = trp.access_point_id,
                    is_exit = trp.is_exit,
                    bill_amount = trp.bill_amount,
                    plate_code = trp.plate_code,
                    plate_number = trp.plate_number,
                    emirates = trp.emirates,
                    trigger_type = trp.trigger_type
                });

                RestClient restC = new RestClient(string.Format("https://parkonic-ai.cloud/"));
                restC.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
                return await restC.ExecuteAsync(req);
            }
            catch (Exception ee)
            {
                throw ee;
            }
        }


    }
}
