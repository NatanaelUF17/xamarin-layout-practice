﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Layouts
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = new CatalogDemo();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

