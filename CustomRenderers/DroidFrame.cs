using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Track.Droid.CustomRenderers;
using Track.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(Track.Views.CardView), typeof(DroidFrame))]
namespace Track.Droid.CustomRenderers
{
    public class DroidFrame : FrameRenderer
    {
        string color;
        public DroidFrame(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {


            base.OnElementChanged(e); if (e.NewElement != null && e.OldElement == null)
            {
              var val=  e.NewElement as CardView;
                color= val.CardBackgroundColor;
                this.SetBackgroundResource(Resource.Drawable.Shape);
                //   var card = (Shape)FindViewById(Resource.Id.msolid);
                GradientDrawable dr = (GradientDrawable)this.Background;
                dr.SetColor(Android.Graphics.Color.ParseColor(color));



            }

        }
    }
}