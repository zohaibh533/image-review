using RestSharp;
using System.Configuration;

namespace ImageReview.Logic
{
    public class SysRestClient
    {
        //public static RestClient GetRestClient()
        //{
        //    if (ConfigurationManager.AppSettings["IsHTTPS"].ToString() == "0")
        //    {
        //        return new RestClient(string.Format("http://192.168.1.12/parkonic/"));
        //    }
        //    else
        //    {
        //        var restClient = new RestClient(string.Format("https://192.168.1.12/parkonic/"));
        //        restClient.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
        //        return restClient;
        //    }
        //}

    }
}
