using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App277.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Xamarin.Forms.ListView), typeof(DisplayOnlyListViewRenderer))]
namespace App277.Droid
{
    // DISABLES LISTVIEW ROW HIGHLIGHT
    [Obsolete]
    public class DisplayOnlyListViewRenderer : ListViewRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ListView> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetSelector(Android.Resource.Color.Transparent);
                Control.CacheColorHint = Android.Graphics.Color.Transparent;
            }
        }
    }
}