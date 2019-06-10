using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace Track.Views
{
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            try
            {
                InitializeComponent();
                card.CardBackgroundColor = "#f8b060";
                card1.CardBackgroundColor = "#f98065";
                card2.CardBackgroundColor = "#f8e061";
                card3.CardBackgroundColor = "#60a5f0";
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
        }
    }
}
