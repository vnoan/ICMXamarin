﻿using ICMXamarin.Model.Api;
using ICMXamarin.Model.Camera.View;
using ICMXamarin.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ICMXamarin
{
	public class App : Application
	{
		public App ()
		{
            // The root page of your application
            MainPage = new CameraPage();
            ComputerVision.MakeRequest();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
