
using Android.Content;

using ESA.Droid.CustomRenderers;
using ESA.Models.CustomRenderers;
using System.Security;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomButtonRenderer))]
namespace ESA.Droid.CustomRenderers
{
    public class CustomButtonRenderer : ButtonRenderer
    {
        public CustomButtonRenderer(Context context) : base(context) { }

        [SecuritySafeCritical]
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> args)
        {
            base.OnElementChanged(args);
            var button = this.Control;
            button.SetAllCaps(false);
        }
    }
}