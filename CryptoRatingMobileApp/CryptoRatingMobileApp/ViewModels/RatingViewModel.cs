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
        }

        public string Text = "test text"; 

        public ICommand ShareCommand { get; }
    }
}
