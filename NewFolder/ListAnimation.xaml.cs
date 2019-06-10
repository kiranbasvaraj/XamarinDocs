using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Track.Views.NewFolder
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListAnimation : ContentPage
	{
		public ListAnimation ()
		{
			InitializeComponent ();
            list.ItemsSource = new List<string>() {"","", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            list.ItemAppearing += List_ItemAppearing;
        }

        private async void List_ItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
           

        }

        private async void vc_Appearing(object sender, EventArgs e)
        {
            try
            {
                var viewCell = (ViewCell)sender;
                await viewCell.View.TranslateTo(150, 0, 7, Easing.SinIn);
                await viewCell.View.TranslateTo(0,0);
            }
            catch (Exception ex)
            {


            }

        }
    }
}