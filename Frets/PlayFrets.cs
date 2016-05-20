
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
using Android.Media;
using System.Threading.Tasks;

namespace Frets
{
	[Activity (Label = "PlayFrets")]			
	public class PlayFrets : Activity
	{
		private const int MAX_STRING = 6;
		private const int MAX_FRET = 8;

		private int ID;
		private string stringID;

		private int dir;
		private string stringDir;

		private Button[][] fretboard;
		private MediaPlayer[][] player;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.PlayFrets);

			InitFrets ();
			foreach (Button[] guitarString in fretboard) {
				foreach (Button fretNum in guitarString) {
					fretNum.Click += OnFretClick;
				}	
			}
		}

		protected void OnFretClick(object sender, EventArgs e)
		{
			Button fretNum = (Button)sender;
			stringDir = (string)fretNum.Tag;
			int i = ((int)Char.GetNumericValue(stringDir[1])) - 1;
			int j = (int)Char.GetNumericValue(stringDir[3]);
			dir = Resources.GetIdentifier (stringDir, "raw", PackageName); //Converts path of file "StringID" to an int ID
			player[i][j] = MediaPlayer.Create(this, dir);
			player[i][j].Start ();
			Delay (i, j);
		}

		private string GetConcatID(int i, int j)
		{
			StringBuilder sb = new StringBuilder ("s");
			sb.Append (i.ToString ());
			sb.Append (("f").ToString ());
			sb.Append (j.ToString ());
			return sb.ToString ();
		}

		private void InitFrets() 
		{
			fretboard = new Button[MAX_STRING][]; // Initialize fretboard
			player = new MediaPlayer[MAX_STRING][];
			for (int i = 0; i < (MAX_STRING); i++) {
				fretboard [i] = new Button[MAX_FRET];
				player [i] = new MediaPlayer[MAX_FRET]; 
			}
			for (int i = 0; i < MAX_STRING; i++)
				for (int j = 0; j < MAX_FRET; j++) {
					stringID = GetConcatID (i+1, j); 
					ID = Resources.GetIdentifier (stringID, "id", PackageName);
					fretboard [i][j] = FindViewById<Button> (ID); // Get the source ID and connect it to Button variable
					fretboard [i][j].Tag = stringID;
			}
		}

		private async void Delay(int i, int j)
		{
			await Task.Delay (5000);
			player [i] [j].Release ();
		}
	}
}