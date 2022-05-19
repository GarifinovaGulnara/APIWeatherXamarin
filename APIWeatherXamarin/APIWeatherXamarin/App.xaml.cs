using APIWeatherXamarin.Views;
using FirstApiLesson.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APIWeatherXamarin
{

    public partial class App : Application
    {
        public static TodoManager TodoManager { get; set; }
        public App()
        {
            InitializeComponent();
            TodoManager = new TodoManager(new RestService());

            MainPage = new WeatherPage();
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
