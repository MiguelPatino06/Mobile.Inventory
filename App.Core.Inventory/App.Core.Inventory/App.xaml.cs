﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App.Core.Inventory
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new MainPage();
		}

        private static object syncroot = new object();
        private static volatile App _instance;
   
        public static App Instance
        {
            get
            {
                if(_instance == null)
                {
                    lock(syncroot)
                    {
                        if (_instance == null)
                            _instance = new App(); 
                    }
                }
                return _instance;
            }
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
