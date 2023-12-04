using ExamenMVVM.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenMVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CalculaView();
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
