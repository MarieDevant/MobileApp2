using MobileApp2.Model;
using MobileApp2.View;
using MobileApp2.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MobileApp2
{
    public partial class App : Application
    {
        public static Load lo;
        public Load Lo { get => lo; set => lo = value; }

        public App()
        {
            User me = new User("me", "password");
			lo= ConnectSQLite.getLoadDatabase(me);
			InitializeComponent();
            this.MainPage = new NavigationPage(new MainPageTest());


        }

        public Load getLoad(){
            return lo;
        }
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
