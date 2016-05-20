using Android.App;
using Android.Widget;
using Android.OS;

namespace Frets
{
	[Activity (Label = "Frets", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);


			// Get our button from the layout resource,
			// and attach an event to it
			Button playButton = FindViewById<Button> (Resource.Id.playFrets);
			Button infoButton = FindViewById<Button> (Resource.Id.aboutPage);

			playButton.Click += delegate {
				StartActivity(typeof(PlayFrets));
			};

			infoButton.Click += delegate {
				StartActivity(typeof(AboutPage));
			};
		}


	}
}


