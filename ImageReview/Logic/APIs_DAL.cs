using RestSharp;
using System;
using System.Net;
using System.Threading.Tasks;

namespace ImageReview.Logic
{
    public static class APIs_DAL
    {
        //public static Task<IRestResponse> CorrectPlateNo(string ServerIP, string TransID,
        //    string PlateCode, string PlateNo, string PlateCity)
        //{
        //    return Task.Run(() =>
        //    {
        //        try
        //        {
        //            RestRequest req = new RestRequest("station/correction", Method.POST, DataFormat.Json);
        //            req.AddHeader("Accept", "application/json");
        //            req.AddJsonBody(new
        //            {
        //                transactionid = TransID,
        //                category = PlateCode,
        //                plate = PlateNo,
        //                city = PlateCity
        //            });

        //            RestClient restC = new RestClient(string.Format("http://{0}/parkonic/", ServerIP));

        //            //RestClient restC = new RestClient(string.Format("http://{0}/parkonic/", ServerIP));
        //            //restC.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

        //            return restC.Execute(req);
        //        }
        //        catch (Exception ee)
        //        {
        //            throw ee;
        //        }
        //    });
        //}

        public static Task<IRestResponse> CorrectPlateNoAWS(string TransID, int AccessPointID,
          string PlateCode, string PlateNo, string PlateCity, string eventDate, int IsException,
          string _Remarks, string _spotNo)
        {
            return Task.Run(() =>
            {
                try
                {
                    RestRequest req = new RestRequest("api/corrected-plate-data", Method.POST, DataFormat.Json);
                    req.AddHeader("Accept", "application/json");
                    req.AddJsonBody(new
                    {
                        transaction_id = TransID,
                        access_point_id = AccessPointID,
                        plate_code = PlateCode,
                        plate_number = PlateNo,
                        emirates = PlateCity,
                        time = eventDate,//DateTime.Now.ToString("yyyy-MM-dd HH:mm:s"),
                        id = 0,
                        is_exit = 1,
                        is_exception = IsException,
                        remarks = _Remarks,
                        correction_user = Utilis.UserName,
                        spot_number = _spotNo,
                        is_verified = 1
                    });

                    RestClient restC = new RestClient("https://api.parkonic.com/");//https://dev.parkonic.com/
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    //restC.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

                    return restC.Execute(req);
                }
                catch (Exception ee)
                {
                    throw ee;
                }
            });
        }

        static string awsToken = "fE7AP9UgZ0eAdIISZGtDP1cML";
        public static Task<IRestResponse> GetSitesAndAccessPoints()
        {
            return Task.Run(() =>
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
                    return restC.Execute(req);
                }
                catch (Exception ee)
                {
                    throw ee;
                }
            });
        }

        public static Task<IRestResponse> GetRecentPlatesResponce(string apID, string eventTime)
        {
            return Task.Run(() =>
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
                    return restC.Execute(req);
                }
                catch (Exception ee)
                {
                    throw ee;
                }
            });
        }

        //public static Task<IRestResponse> CancelTrip(string TripID)
        //{
        //    return Task.Run(() =>
        //    {
        //        try
        //        {
        //            RestRequest req = new RestRequest("api/plate-correction/cancel-plate", Method.POST, DataFormat.Json);
        //            req.AddHeader("Accept", "application/json");
        //            req.AddJsonBody(new
        //            {
        //                trip_id = TripID
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

        public static Task<IRestResponse> ReplaceTrip(string TripID, string code, string PlateNo, string city, string user)
        {
            return Task.Run(() =>
            {
                try
                {
                    RestRequest req = new RestRequest("api/plate-correction/replace-plate", Method.POST, DataFormat.Json);
                    req.AddHeader("Accept", "application/json");
                    req.AddJsonBody(new
                    {
                        trip_id = TripID,
                        plate_code = code,
                        plate_number = PlateNo,
                        emirates = city,
                        correction_user = user,
                        is_exception = 0
                    });

                    RestClient restC = new RestClient("https://api.parkonic.com/");
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    return restC.Execute(req);
                }
                catch (Exception ee)
                {
                    throw ee;
                }
            });
        }

        public static Task<IRestResponse> PlateCorrectionNotification()
        {
            return Task.Run(() =>
            {
                try
                {
                    RestRequest req = new RestRequest("api/info/plate-correction-notification", Method.POST, DataFormat.Json);
                    req.AddHeader("Accept", "application/json");
                    req.AddJsonBody(new
                    {
                        token = awsToken
                    });

                    RestClient restC = new RestClient("https://api.parkonic.com/");
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    return restC.Execute(req);
                }
                catch (Exception ee)
                {
                    throw ee;
                }
            });
        }

        public static Task<IRestResponse> GetPlateActiveTripDetail(string PlateCode, string PlateNo, string PlateCity)
        {
            return Task.Run(() =>
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
                    return restC.Execute(req);
                }
                catch (Exception ee)
                {
                    throw ee;
                }
            });
        }

        //public static Task<IRestResponse> ResetPassword(string UserName, string NewPassword)
        //{
        //    return Task.Run(() =>
        //    {
        //        try
        //        {
        //            RestRequest req = new RestRequest("update_password_admin", Method.POST, DataFormat.Json);
        //            req.AddHeader("Accept", "application/json");
        //            req.AddJsonBody(new { username = UserName, new_password = NewPassword });
        //            return SysRestClient.GetRestClient().Execute(req);
        //        }
        //        catch (Exception ee)
        //        {
        //            throw ee;
        //        }
        //    });
        //}

        //public static Task<IRestResponse> ChangePassword(string UserName, string CurrentPassword, string NewPassword)
        //{
        //    return Task.Run(() =>
        //    {
        //        try
        //        {
        //            RestRequest req = new RestRequest("update_password", Method.POST, DataFormat.Json);
        //            req.AddHeader("Accept", "application/json");
        //            req.AddJsonBody(new { username = UserName, current_password = CurrentPassword, new_password = NewPassword });
        //            return SysRestClient.GetRestClient().Execute(req);
        //        }
        //        catch (Exception ee)
        //        {
        //            throw ee;
        //        }
        //    });
        //}

        //public static Task<IRestResponse> CreateUser(string UserName, string Password, string Salt)
        //{
        //    return Task.Run(() =>
        //    {
        //        try
        //        {
        //            RestRequest req = new RestRequest("create_user", Method.POST, DataFormat.Json);
        //            req.AddHeader("Accept", "application/json");
        //            req.AddJsonBody(new { username = UserName, password = Password, salt = Salt });
        //            return SysRestClient.GetRestClient().Execute(req);
        //        }
        //        catch (Exception ee)
        //        {
        //            throw ee;
        //        }
        //    });
        //}

        //public static Task<IRestResponse> GetAuthenticationResponce(string UserName, string Password)
        //{
        //    return Task.Run(() =>
        //    {
        //        try
        //        {
        //            RestRequest req = new RestRequest("authentication", Method.POST, DataFormat.Json);
        //            req.AddHeader("Accept", "application/json");
        //            req.AddJsonBody(new { username = UserName, password = Password, device_id = "" });
        //            return SysRestClient.GetRestClient().Execute(req);
        //        }
        //        catch (Exception ee)
        //        {
        //            throw ee;
        //        }
        //    });
        //}




    }
}
