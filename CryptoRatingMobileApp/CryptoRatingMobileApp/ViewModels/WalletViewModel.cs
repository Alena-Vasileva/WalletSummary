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
            OpenWebCommand = new Command(async () => await ServerConnect.GetZerion());
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
            RatingViewModel.inf1 = profile.absolute_change_24h.ToString();
            RatingViewModel.inf2 = profile.assets_value.ToString();
            RatingViewModel.inf3 = profile.relative_change_24h.ToString();
            await Shell.Current.GoToAsync($"{nameof(RatingPage)}");
        }

        public ICommand OpenWebCommand { get; }
        public ICommand OpenRatingCommand { get; }
    }
}