using CryptoRatingMobileApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CryptoRatingMobileApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}