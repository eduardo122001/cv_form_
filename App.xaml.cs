﻿using form.vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace form
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           MainPage = new NavigationPage(new MainPage());
         // MainPage = new convertir();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
