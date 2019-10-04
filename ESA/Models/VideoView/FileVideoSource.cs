using Xamarin.Forms;

namespace ESA.Models.VideoView
{
    /**
     * <summary>
     * Extends VideoSource with FileProperty so that VideoPlayers can correctly interpret video file paths chosen from within the device.
     * </summary>
     * 
     * <remarks>
     * <see cref="VideoSource"/>
     * <see cref="VideoPlayer"/>
     * </remarks>
     */
    public class FileVideoSource : VideoSource
    {
        public static readonly BindableProperty FileProperty = BindableProperty.Create(nameof(File), typeof(string), typeof(FileVideoSource));

        public string File
        {
            set { SetValue(FileProperty, value); }
            get { return (string)GetValue(FileProperty); }
        }
    }
}