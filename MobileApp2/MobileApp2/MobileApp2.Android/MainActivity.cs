using System;
using Newtonsoft.Json;
using System.IO;
using MobileApp2;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MobileApp2.Droid
{
	[Activity (Label = "MobileApp2", Icon = "@drawable/icon", Theme="@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar; 

			base.OnCreate (bundle);
			String json = "";

			using (StreamReader sr = new StreamReader(Assets.Open("TestDatabase.json")))
			{
				json = sr.ReadToEnd();
			}


			global::Xamarin.Forms.Forms.Init (this, bundle);
            App app = new MobileApp2.App();
            app.setJsonData(json);
			LoadApplication (app);


		}
	}
}

