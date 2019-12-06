using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HelpDesk.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;
using AToolbar = Android.Support.V7.Widget.Toolbar;
[assembly: ExportRenderer(typeof(NavigationPage), typeof(DroidNavigationPage))]
namespace HelpDesk.Droid.CustomRenderers
{
    public class DroidNavigationPage : NavigationPageRenderer
    {
        Context mContx;

        public DroidNavigationPage(Context context) : base(context)
        {
            mContx = context;
        }
        public AToolbar toolbar;
        public Activity context;

        protected override Task<bool> OnPushAsync(Page view, bool animated)
        {
            var retVal = base.OnPushAsync(view, animated);

            context = (Activity)Xamarin.Forms.Forms.Context;
            toolbar = context.FindViewById<Android.Support.V7.Widget.Toolbar>(Droid.Resource.Id.toolbar);

            if (toolbar != null)
            {
                if (toolbar.NavigationIcon != null)
                {
                    toolbar.NavigationIcon = Android.Support.V4.Content.ContextCompat.GetDrawable(context, Resource.Drawable.ic_back);
                    //toolbar.SetNavigationIcon(Resource.Drawable.Back);
                }
            }
            return retVal;
        }
        //private Android.Support.V7.Widget.Toolbar GetToolBar()
        //{
        //    // return (CrossCurrentActivity.Current?.Activity as MainActivity).FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
        //    return FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
        //}
        //protected override void OnElementChanged(ElementChangedEventArgs<NavigationPage> e)
        //{
        //    base.OnElementChanged(e);
        //    var toolbar = GetToolBar();
        //    if (toolbar != null)
        //    {
        //        toolbar.SetNavigationIcon(Resource.Drawable.ic_back);
        //    }


        //}

        //protected override void OnLayout(bool changed, int l, int t, int r, int b)
        //{
        //    base.OnLayout(changed, l, t, r, b);
        //    var toolbar = GetToolBar();
        //    if (toolbar != null)
        //    {
        //        toolbar.SetNavigationIcon(Resource.Drawable.ic_back);
        //        //for (var i = 0; i < toolbar.ChildCount; i++)
        //        //{
        //        //    var imageButton = toolbar.GetChildAt(i) as Android.Widget.ImageButton;

        //        //    var drawerArrow = imageButton?.Drawable as DrawerArrowDrawable;
        //        //    if (drawerArrow == null)
        //        //        continue;
        //        //    imageButton.SetMaxHeight(60);
        //        //    imageButton.SetMaxWidth(60);
        //        //    imageButton.SetImageDrawable(mContx.GetDrawable(Resource.Drawable.menu3));

        //        //}
        //    }
        //}
    }
}