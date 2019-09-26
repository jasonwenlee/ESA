using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ESA.Models.VideoView
{
    /**
     * Author:  Douglas Hudson Walker
     * 
     * Summary: Defines the additional properties for our video player which are not found in the 'View' class. 
     * 
     * Remarks:
     *
     * Walkthrough: 
     *      When we create a video view in our page (xaml) by writing <video:VideoPlayer /> the solution will follow our xmlns page reference and come here 
     *      to build the video component as we have defined it. This class derives the majority of it's properties and features from the 'View' class. So it's
     *      worth summarizing the view class if your unfamiliar, if not, skip the next paragraph.
     *          
     *      The 'View' class
     *      In xamarin the view class is the building block of most cross platform controls like Image, WebView, Map, Button, etc. All of these controls inherit 
     *      from the view class see https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.view?view=xamarin-forms for more. 'View' provides more than 70 
     *      properties to the classes that inherit it, including; 'BackgroundColour', 'Id', 'Margin', 'Width', 'Height', all the good stuff. It's a very useful 
     *      class to inherit from when building a custom control.
     *      
     *      So what does our Video Player have that 'View' does not?
     *      We want to build a cross platform custom control for our xamarin project viewable in iOS, Android and UWP. Our VideoPlayer accomplishs this by 
     *      extending the View class to include properties which can then be understood by our iOS, Android and UWP projects. Our Video player extends View with 
     *      the following properties:
     *          Source: the source path or uri for the video it wants to play. 
     *          AutoPlay: Our video could have autoplay functionality (true or false)
     *          Status: (Playing, paused, preparing) 
     *          Duration: The lenght of the video
     *          Position: The current TimeStamp of the video
     *          TimeToEnd: the time left until the end of the video
     *          AreTransportControlsEnabled: player controls are needed (true or false)
     *          
     *      Along with these additional properties we also want include some additional methods for Pausing, Playing, Stopping and SettingTimeStamp. These are used
     *      mostly with custom made transport controls, where we can define the button design and location by building the methods into our xaml 
     *      
     */

    public class VideoPlayer : View, IVideoPlayerController
    {
        public event EventHandler UpdateStatus;

        public VideoPlayer()
        {
            Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
            {
                UpdateStatus?.Invoke(this, EventArgs.Empty);
                return true;
            });
        }

        // AreTransportControlsEnabled property
        public static readonly BindableProperty AreTransportControlsEnabledProperty =
            BindableProperty.Create(nameof(AreTransportControlsEnabled), typeof(bool), typeof(VideoPlayer), true);

        public bool AreTransportControlsEnabled
        {
            set { SetValue(AreTransportControlsEnabledProperty, value); }
            get { return (bool)GetValue(AreTransportControlsEnabledProperty); }
        }

        // Source property
        public static readonly BindableProperty SourceProperty =
            BindableProperty.Create(nameof(Source), typeof(VideoSource), typeof(VideoPlayer), null);

        [TypeConverter(typeof(VideoSourceConverter))]
        public VideoSource Source
        {
            set { SetValue(SourceProperty, value); }
            get { return (VideoSource)GetValue(SourceProperty); }
        }

        // AutoPlay property
        public static readonly BindableProperty AutoPlayProperty =
            BindableProperty.Create(nameof(AutoPlay), typeof(bool), typeof(VideoPlayer), true);

        public bool AutoPlay
        {
            set { SetValue(AutoPlayProperty, value); }
            get { return (bool)GetValue(AutoPlayProperty); }
        }

        // Status read-only property
        private static readonly BindablePropertyKey StatusPropertyKey =
            BindableProperty.CreateReadOnly(nameof(Status), typeof(VideoStatus), typeof(VideoPlayer), VideoStatus.NotReady);

        public static readonly BindableProperty StatusProperty = StatusPropertyKey.BindableProperty;

        public VideoStatus Status
        {
            get { return (VideoStatus)GetValue(StatusProperty); }
        }

        VideoStatus IVideoPlayerController.Status
        {
            set { SetValue(StatusPropertyKey, value); }
            get { return Status; }
        }

        // Duration read-only property
        private static readonly BindablePropertyKey DurationPropertyKey =
            BindableProperty.CreateReadOnly(nameof(Duration), typeof(TimeSpan), typeof(VideoPlayer), new TimeSpan(),
                propertyChanged: (bindable, oldValue, newValue) => ((VideoPlayer)bindable).SetTimeToEnd());

        public static readonly BindableProperty DurationProperty = DurationPropertyKey.BindableProperty;

        public TimeSpan Duration
        {
            get { return (TimeSpan)GetValue(DurationProperty); }
        }

        TimeSpan IVideoPlayerController.Duration
        {
            set { SetValue(DurationPropertyKey, value); }
            get { return Duration; }
        }

        // Position property
        public static readonly BindableProperty PositionProperty =
            BindableProperty.Create(nameof(Position), typeof(TimeSpan), typeof(VideoPlayer), new TimeSpan(),
                propertyChanged: (bindable, oldValue, newValue) => ((VideoPlayer)bindable).SetTimeToEnd());

        public TimeSpan Position
        {
            set { SetValue(PositionProperty, value); }
            get { return (TimeSpan)GetValue(PositionProperty); }
        }

        // TimeToEnd property
        private static readonly BindablePropertyKey TimeToEndPropertyKey =
            BindableProperty.CreateReadOnly(nameof(TimeToEnd), typeof(TimeSpan), typeof(VideoPlayer), new TimeSpan());

        public static readonly BindableProperty TimeToEndProperty = TimeToEndPropertyKey.BindableProperty;

        public TimeSpan TimeToEnd
        {
            private set { SetValue(TimeToEndPropertyKey, value); }
            get { return (TimeSpan)GetValue(TimeToEndProperty); }
        }

        void SetTimeToEnd()
        {
            TimeToEnd = Duration - Position;
        }

        // Methods handled by renderers
        public event EventHandler PlayRequested;

        public void Play()
        {
            PlayRequested?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler PauseRequested;

        public void Pause()
        {
            PauseRequested?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler StopRequested;

        public void Stop()
        {
            StopRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
