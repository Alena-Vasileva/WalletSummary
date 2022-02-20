using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using CryptoRatingMobileApp.Views;
using System.Threading.Tasks;
using CryptoRatingMobileApp.Services;

namespace CryptoRatingMobileApp.ViewModels
{
    internal class RatingViewModel : BaseViewModel
    {
        public RatingViewModel()
        {
            ShareCommand = new Command(async () => await ShareContent.ShareText(Text));
            ZerionCommand = new Command(async () => await Browser.OpenAsync("https://app.zerion.io/connect-wallet"));
        }

        public string Text = "test text";

        public static string inf1="Enter wallet";
        public string Inf1
        {
            get => inf1;
            set => SetProperty(ref inf1, value);
        }

        public static string inf2 = "Enter wallet";
        public string Inf2
        {
            get => inf2;
            set => SetProperty(ref inf2, value);
        }

        public static string inf3 = "Enter wallet";
        public string Inf3
        {
            get => inf3;
            set => SetProperty(ref inf3, value);
        }

        public ICommand ShareCommand { get; }
        public ICommand ZerionCommand { get; }
    }
}
