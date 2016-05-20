
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

namespace Frets
{
	[Activity (Label = "AboutPage")]			
	public class AboutPage : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.AboutPage);

			Button linkToYoutube = FindViewById<Button> (Resource.Id.linkToYoutube);
			Button linkToFacebook = FindViewById<Button> (Resource.Id.linkToFacebook);

			linkToFacebook.Click += delegate {
				var uri = Android.Net.Uri.Parse ("http://www.facebook.com/tamlumusic/");
				var intent = new Intent (Intent.ActionView, uri);  
				StartActivity (intent);
			};

			linkToYoutube.Click += delegate {
				var uri = Android.Net.Uri.Parse ("http://www.youtube.com/tamlumusic/");
				var intent = new Intent (Intent.ActionView, uri);  
				StartActivity (intent);
			};
		}
	}
}

