using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCalendarProject.Services;

namespace XamarinCalendarProject
{
    public partial class App : Application
    {
        private static ServiceDependency _Locator;
        public static ServiceDependency Locator
        {
            get
            {
                return _Locator = _Locator ?? new ServiceDependency();
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
