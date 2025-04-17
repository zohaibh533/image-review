using System;
using System.Collections.Generic;
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

        private static Dictionary<char, string> ArEngLetters = new Dictionary<char, string>()
        {
            {'ا', "A"},  {'ب', "B"}, {'ح', "J"},
            {'د', "D"}, {'ر', "R"}, {'س', "S"},
            {'ص', "X"}, {'ط', "T"}, {'ع', "E"},
            {'ق', "G"}, {'ك', "K"}, {'ل', "L"},
             {'م', "Z"}, {'ن', "N"},  {'ه', "H"},
             {'و', "U"}, {'ى', "V"},

             {'ت', ""}, {'ث', ""}, {'ج', ""},
              {'خ', ""}, {'ذ', ""}, {'ز', ""},
              {'ش', ""}, {'ض', ""},  {'ظ', ""},
              {'غ', ""}, {'ف', ""},

            {'٠', "0"}, {'١', "1"}, {'٢', "2"}, {'٣', "3"},
            {'٤', "4"}, {'٥', "5"}, {'٦', "6"}, {'٧', "7"},
            {'٨', "8"}, {'٩', "9"}
        };



        // {'ت', "t"}, {'ث', "'t"}, {'ج', "j"},
        //{'خ', "h"}, {'ذ', "d"}, {'ز', "z"},
        //{'ش', "s"}, {'ض', "d"},  {'ظ', "'z"},
        //{'غ', "'g"}, {'ف', "f"},

        public static string GetEnglishCharacter(string arabicLetter)
        {
            return ArEngLetters.ContainsKey(arabicLetter[0]) ? ArEngLetters[arabicLetter[0]] : " "; // Return '?' if not found
        }

        private static Dictionary<string, char> EngArLetters = new Dictionary<string, char>();

        public static string ConvertEnglishToArabic(string input)
        {
            foreach (var pair in ArEngLetters)
            {
                if (!string.IsNullOrEmpty(pair.Value))
                    EngArLetters[pair.Value] = pair.Key;
            }

            StringBuilder result = new StringBuilder();
            char arabicChar;
            foreach (char c in input.ToUpper())
            {
                if (EngArLetters.TryGetValue(c.ToString(), out arabicChar))
                    result.Append(arabicChar);
                //else
                //{
                //    result.Append(c); // Keep unknown characters as is
                //}
            }
            return result.ToString();
        }
    }
}
