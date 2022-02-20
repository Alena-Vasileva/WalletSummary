using CryptoRatingMobileApp.ViewModels;
using CryptoRatingMobileApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CryptoRatingMobileApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(WalletPage), typeof(WalletPage));
            Routing.RegisterRoute(nameof(RatingPage), typeof(RatingPage));
        }

    }
}
