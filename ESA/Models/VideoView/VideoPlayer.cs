using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ESA.Models.VideoView
{
    /**
     * Author:  Douglas Hudson Walker
     * 
     * Summary: Android, iOS and UWP already have native video players. They are all implemented differently and there is no cross-platform video control built into 
     * xamararin like there is for images. To implement a video player in xamarin, we need to write the classes which tell xamarin what native components we want to
     * use (i.e. 'TextBox' in C# and UWP is 'Label' in iOS and 'TextView' in Android). To do this we extend the 'View' class, which is the heart of xamarin's cross-
     * platform abilities. It is the building block of controls like Image, WebView, Map, and Button; which all inherit the view class and in turn it provides them 
     * with more than 70 properties. Everything from 'BackgroundColour' to 'Id', 'Margin' and 'Width'. Inheriting the view class means we can use xamarins built in 
     * abilities for translation and from there, we can add the additional properies we require for our VideoPlayer.
     * When we run our application and present our custom video player, our VideoPlayer class is called. If we run our class on UWP we will find our VideoPlayer
     * will call on the xamarin 'ViewRenderer' which is the translator for our xamarin custom components (our VideoPlayer) and UWP's native components (in this case
     * 'MediaPlayer'). For this translator to work we need to describe which native component we wish to call and how to render it. For this reason; we also need to
     * write a 'VideoPlayerRenderer' for each platform (iOS, Android and UWP). 
     * https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.view?view=xamarin-forms
     * 
     * 
     * 
     *      So what does our Video Player have that 'View' does not?
     *      We want to build a cross platform custom control for our xamarin project viewable in iOS, Android and UWP. Our VideoPlayer accomplishes this by 
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

        // AreTransportControlsEnabled property (Transport controls are (play, pause, stop, etc.))
        public static readonly BindableProperty AreTransportControlsEnabledProperty =
            BindableProperty.Create(nameof(AreTransportControlsEnabled), typeof(bool), typeof(VideoPlayer), true);

        public bool AreTransportControlsEnabled
        {
            set { SetValue(AreTransportControlsEnabledProperty, value); }
            get { return (bool)GetValue(AreTransportControlsEnabledProperty); }
        }

        // Source property (The source of the video file, uri, or embedded resource)
        public static readonly BindableProperty SourceProperty =
            BindableProperty.Create(nameof(Source), typeof(VideoSource), typeof(VideoPlayer), null);

        [TypeConverter(typeof(VideoSourceConverter))]
        public VideoSource Source
        {
            set { SetValue(SourceProperty, value); }
            get { return (VideoSource)GetValue(SourceProperty); }
        }

        // AutoPlay property (whether we wnat to play the video as soon as it is ready)
        public static readonly BindableProperty AutoPlayProperty =
            BindableProperty.Create(nameof(AutoPlay), typeof(bool), typeof(VideoPlayer), true);

        public bool AutoPlay
        {
            set { SetValue(AutoPlayProperty, value); }
            get { return (bool)GetValue(AutoPlayProperty); }
        }

        // Status read-only property (playing, paused, preparing)
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

        // Duration read-only property (How long the video is)
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

        // Position property (The current timestamp or time elapsed)
        public static readonly BindableProperty PositionProperty =
            BindableProperty.Create(nameof(Position), typeof(TimeSpan), typeof(VideoPlayer), new TimeSpan(),
                propertyChanged: (bindable, oldValue, newValue) => ((VideoPlayer)bindable).SetTimeToEnd());

        public TimeSpan Position
        {
            set { SetValue(PositionProperty, value); }
            get { return (TimeSpan)GetValue(PositionProperty); }
        }

        // TimeToEnd property (The amount of time remaining)
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
