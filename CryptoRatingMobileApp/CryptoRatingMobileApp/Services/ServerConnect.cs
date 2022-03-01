using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

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
            HttpClient client = new HttpClient();
            //await client.PostAsync(ur + "/add/", stringContent);
            //string result = await client.GetStringAsync("https://app.zerion.io/" + token + "/overview");
            //System.Diagnostics.Debug.WriteLine(result);
            MyString mstr = new MyString(token);
            //var stringContent = new StringContent(JsonSerializer.Serialize<string>(token));
            //var response = await client.PostAsync("http://194.67.121.113:8000/get_profile_info", stringContent);
            //string result = await response.Content.ReadAsStringAsync();
            
            //System.Diagnostics.Debug.WriteLine(result);
            //return await Task.FromResult(true);
            //return JsonConvert.DeserializeObject<ProfileParse>(result);
            return new ProfileParse() { assets_value = 6230.5652, absolute_change_24h = -162.6369, relative_change_24h = -2.4638 };
        }


        public static async Task<RootParse> GetAssets(string token)
        {
            HttpClient client = new HttpClient();
            //wait client.PostAsync(url + "/add/", stringContent);
            //string result = await client.GetStringAsync(url);
            //return JsonConvert.DeserializeObject<ProfileParse>(result);
            return new RootParse();
        }
    }

    public class ProfileParse
    {
        public double absolute_change_24h;
        public double assets_value;
        public double relative_change_24h;
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
