using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CryptoRatingMobileApp.Services
{
    public static class ServerConnect
    {
        public static string urlProfile = "";

        public static string UserToken;

        public static string Info;

        public static async Task<ProfileParse> GetZerion()
        {
            HttpClient client = new HttpClient();
            //await client.PostAsync(ur + "/add/", stringContent);
            string result = await client.GetStringAsync("https://app.zerion.io/" + UserToken + "/overview");
            System.Diagnostics.Debug.WriteLine(result);
            return JsonConvert.DeserializeObject<ProfileParse>(result);
        }

        public static async Task<ProfileParse> GetSummary(string token)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("STARTED " + "http://194.67.121.113:8080/subscribe/profile/" + token);
                HttpClient client = new HttpClient();
                client.Timeout = TimeSpan.FromSeconds(8);
                string result = await client.GetStringAsync("http://194.67.121.113:8080/subscribe/profile/" + token);
                /*string result = "";
                if (token == "0x42b9df65b219b3dd36ff330a4dd8f327a6ada990")
                {
                    result = "{\"absolute_change_24h\": 111.95139302446205,  \"assets_value\": 5801.775144738031, \"relative_change_24h\": 1.8928003897737304}";
                }
                else
                {
                    throw new Exception();
                }*/
                System.Diagnostics.Debug.WriteLine(result);
                return JsonConvert.DeserializeObject<ProfileParse>(result);
            }
            catch (Exception)
            {
                return new ProfileParse() { assets_value = "Incorrect wallet", absolute_change_24h = "Incorrect wallet", relative_change_24h = "Incorrect wallet" };
            }
        }


        //public static async Task<RootParse> GetAssets(string token)
        //{
        //    HttpClient client = new HttpClient();
        //    //wait client.PostAsync(url + "/add/", stringContent);
        //    //string result = await client.GetStringAsync(url);
        //    //return JsonConvert.DeserializeObject<ProfileParse>(result);
        //    return new RootParse();
        //}
    }

    public class ProfileParse
    {
        public string absolute_change_24h;
        public string assets_value;
        public string relative_change_24h;
    }

    public class MyString
    {

        public MyString(string t)
        {
            user_token = t;
        }
        public string user_token;
    }

    public class RootParse
    {
        public double current_price;
        public string icon_url;
        public string id;
        public string name;
        public string quantity;
        public double relative_change_24h;
    }
}
