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
        public static string jsonString;
        public static Load lo;
        public string JsonString { get => jsonString; set => jsonString = value; }
        public Load Lo { get => lo; set => lo = value; }

        public App()
        {
			lo = LoadJson.LoadTheJson(JsonString);
            AppDomain.CurrentDomain.SetData("load",lo);
			InitializeComponent();
            this.MainPage = new NavigationPage(new MainPageTest());


        }

        public void setJsonData(string json){
            jsonString = json;
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
