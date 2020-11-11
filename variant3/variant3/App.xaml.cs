using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using variant3.Services;
using variant3.Views;

namespace variant3
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new page();
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
