using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using CryptoRatingMobileApp.Views;
using System.Threading.Tasks;
using CryptoRatingMobileApp.Services;

namespace CryptoRatingMobileApp.ViewModels
{
    public class WalletViewModel : BaseViewModel
    {
        public WalletViewModel()
        {
            Title = "Wallet";
            OpenRatingCommand = new Command(async () => await UpdateRating());
        }

        private string token;
        public string Token
        {
            get => token;
            set => SetProperty(ref token, value);
        }

        async Task UpdateRating()
        {
            ServerConnect.UserToken=token;
            System.Diagnostics.Debug.WriteLine(token);
            ProfileParse profile = await ServerConnect.GetSummary(token);
            RatingViewModel.LinkRatingPage.Inf1 = profile.absolute_change_24h;
            RatingViewModel.LinkRatingPage.Inf2 = profile.assets_value;
            RatingViewModel.LinkRatingPage.Inf3 = profile.relative_change_24h;
            (Shell.Current as AppShell)?.SetSummary();
        }

        public ICommand OpenRatingCommand { get; }
    }
}