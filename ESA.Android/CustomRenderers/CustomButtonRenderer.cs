using System.ComponentModel;
using System.IO;

using Android.Content;
using Android.Widget;

using ESA.Droid.CustomRenderers;
using ESA.Models.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomButtonRenderer))]
namespace ESA.Droid.CustomRenderers
{
    public class CustomButtonRenderer : ButtonRenderer
    {
        public CustomButtonRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> args)
        {
            base.OnElementChanged(args);
            var button = this.Control;
            button.SetAllCaps(false);
        }
    }
}