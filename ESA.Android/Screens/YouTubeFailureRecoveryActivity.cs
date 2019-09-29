﻿using System;
using Android.App;
using Android.Content;
using Android.Widget;
using Com.Google.Android.Youtube.Player;

namespace ESA.Droid.Screens
{
    //[Activity (Label = "YouTubeFailureRecoveryActivity")]			
    public abstract class YouTubeFailureRecoveryActivity : YouTubeBaseActivity, IYouTubePlayerOnInitializedListener
    {
        private static int RECOVERY_DIALOG_REQUEST = 1;
        public void OnInitializationFailure(IYouTubePlayerProvider provider, YouTubeInitializationResult errorReason)
        {
            if (errorReason.IsUserRecoverableError)
            {
                errorReason.GetErrorDialog(this, RECOVERY_DIALOG_REQUEST).Show();
            }
            else
            {
                String errorMessage = String.Format(GetString(Resource.String.error_player), errorReason.ToString());
                Toast.MakeText(this, errorMessage, ToastLength.Long).Show();
            }
        }

        public virtual void OnInitializationSuccess(IYouTubePlayerProvider provider, IYouTubePlayer player, bool wasRestored)
        {
            //throw new NotImplementedException ();
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            //base.OnActivityResult (requestCode, resultCode, data);
            if (requestCode == RECOVERY_DIALOG_REQUEST)
                GetYouTubePlayerProvider().Initialize(DeveloperKey.Key, this);
        }

        protected abstract IYouTubePlayerProvider GetYouTubePlayerProvider();

    }
}