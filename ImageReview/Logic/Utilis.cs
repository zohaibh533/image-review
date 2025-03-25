using System;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;

namespace ImageReview.Logic
{
    public static class Utilis
    {
        public static int UserID { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static string UserType { get; set; }
        public static bool IsArabicUser { get; set; }
        public static string CorrectionFolderPath { get; set; }
        public static string ForwardFolderPath { get; set; }
        public static string ModificationFolderPath { get; set; }
        public static int LoginID { get; set; }
        public static string ReviewPath { get; set; }

        public static string dbPwd { get; set; }
        public static string dbServer { get; set; }
        public static string dbUser { get; set; }

        //SHA256
        private static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        public static DateTime ConvertTransactionIDToDateTime(string TransID, string AccessPointID)
        {
            return (new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc))
                .AddMilliseconds(Convert.ToDouble(TransID.Substring(AccessPointID.Length)))
                .ToLocalTime();
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                // Check for IPv4 address
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "";
        }

    }
}
