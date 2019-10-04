using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA.MarkupExtensions
{

    // Author:      Douglas Hudson Walker

    // Summary:     This class extends our xaml to include the ProvideValue method. It takes a 'serviceProvider' (in this case the serviceProvider is anything that calls our class in 
    //              xaml (a Button or ImageButton)) and then searches for our project files or assembly for the Resource. If found, the 
    //              object (in this case an Image) is returned. 

    // Remarks:     Why can't we just include a relative path, like normal? 
    //              "There is no built in type converter from string to 'ResourceImageSource' (Type which handles Images in Xamarin), these types of 
    //              images cannot be natively loaded by xaml." (https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/images?tabs=windows for more info).
    //              Not sure why the Xamarin Devs have not just implemented this...
    //              
    //              On another note; MarkupExtensions seem super useful. You can write code to change the way xaml interprets component properties. With MarkupExtensions you 
    //              can set any Color properties to take Hue values (instead of RGB, I find Hue values way more intuitive), you can add unconventional resource paths for bitmaps 
    //              or 'R' data files. It's a super cool way to write plugins for your xaml designer and make your coding style easier in VS :)

    //              For Images to be loaded their BuildAction must be set as 'Embedded Resource' this can be done in the solution explorer accessing the image's properties. 
    //              No error is thrown if this is excluded, your image just won't show up on runtime-->
    //              <!--The source property for these buttons refers to the included assembly reference 'mrkupExt'. 
    //              The path name is then seperated by periods '.' (no idea why; slashes must be used for something else...)


    [ContentProperty(nameof(ImageResource))]
    public class ImageResourceExtension : IMarkupExtension  // IMarkupExtension is an interface used to create XAML extensions. 
    {
        public string ImageResource { get; set; }


        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ImageResource == null) { return null; }
            // Find an image from resource and set the imagesource to it
            var imageSource = ImageSource.FromResource(ImageResource, typeof(ImageResourceExtension).GetTypeInfo().Assembly);
            return imageSource;
        }

    }
}