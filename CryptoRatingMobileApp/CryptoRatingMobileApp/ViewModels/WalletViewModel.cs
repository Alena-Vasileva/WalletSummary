using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using CryptoRatingMobileApp.Views;
using System.Threading.Tasks;

namespace CryptoRatingMobileApp.ViewModels
{
    public class WalletViewModel : BaseViewModel
    {
        public WalletViewModel()
        {
            Title = "Wallet";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://app.zerion.io/connect-wallet"));
            OpenRatingCommand = new Command(async () => await UpdateRating());
        }

        async Task UpdateRating()
        {
            await Browser.OpenAsync("https://app.zerion.io/connect-wallet");
        }

        public ICommand OpenWebCommand { get; }
        public ICommand OpenRatingCommand { get; }
    }
}