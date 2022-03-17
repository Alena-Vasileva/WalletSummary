using CryptoRatingMobileApp.ViewModels;
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
                Text = $"My Wallet Statistics" +
                $"\r\nAbsolute Change 24h = {RatingViewModel.LinkRatingPage.Inf1}" +
                $"\r\nAssets Value = {RatingViewModel.LinkRatingPage.Inf2}" +
                $"\r\nRelative Change 24h = {RatingViewModel.LinkRatingPage.Inf3}",
                Title = "My Wallet Sttistic"
            });
        }
    }
}
