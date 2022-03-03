using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using CryptoRatingMobileApp.Views;
using System.Threading.Tasks;
using CryptoRatingMobileApp.Services;
using System.Threading;
using System.Globalization;

namespace CryptoRatingMobileApp.ViewModels
{
    internal class RatingViewModel : BaseViewModel
    {
        public static RatingViewModel LinkRatingPage;

        public RatingViewModel()
        {
            ShareCommand = new Command(async () => await ShareContent.ShareText(Text));
            ZerionCommand = new Command(async () => await Browser.OpenAsync("https://app.zerion.io/connect-wallet"));
            LinkRatingPage = this;
        }

        public string Text = "test text";

        public static string inf1="Enter wallet";
        public string Inf1
        {
            get => inf1;
            set => SetProperty(ref inf1, Round(value));
        }

        public static string inf2 = "Enter wallet";
        public string Inf2
        {
            get => inf2;
            set => SetProperty(ref inf2, Round(value));
        }

        public static string inf3 = "Enter wallet";
        public string Inf3
        {
            get => inf3;
            set => SetProperty(ref inf3, Round(value));
        }

        public ICommand ShareCommand { get; }
        public ICommand ZerionCommand { get; }

        private string Round(string accurateValue)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-AR"); // Espanol - Argentina
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-AR");// Espanol - Argentina
            if (double.TryParse(accurateValue, out double x))
            {
                string res = "";
                int n = accurateValue.Length;
                for (int i = 0; i < n; i++)
                {
                    res += accurateValue[i];
                    if (accurateValue[i]=='.')
                    {
                        n = i + 3;
                    }
                }
                return res;
            }
            else
            {
                return accurateValue;
            }
        }
    }
}
