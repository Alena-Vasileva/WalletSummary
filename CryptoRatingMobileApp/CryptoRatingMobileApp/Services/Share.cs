using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace CryptoRatingMobileApp.Services
{
    public class ShareContent
    {
        public static async Task ShareText(string text)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Text = "My Wallet Statistics\r\nAbsolute Change_24h= -162.6369\r\nAssets Value = 6230.5652\r\nRelative Change 24h = -2.4638",
                Title =
                "My Wallet Sttistic \r\nAbsolute Change_24h=-162.6369\r\nAssets Value = 6230.5652\r\nRelative Change 24h = -2.4638"
            }); 
        }
    }
}
