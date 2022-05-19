using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APIWeatherXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var a = await App.TodoManager.GetTodoItemModels(cityEnterEntry.Text);
            DateTime d = DateTime.Now;
            datetimelbl.Text = d.ToString();
            tempLbl.Text = "t" + " " + a.main.temp.ToString();
            feelLikeLbl.Text = "ощущается как" + " " + a.main.feels_like.ToString();
            WindLbl.Text = "направление ветра" + " " + a.wind.gust.ToString();
            HumidityLbl.Text = "влажность" + " " + a.main.humidity.ToString();
            PressureLbl.Text = "давление" + " " + a.main.pressure.ToString();
        }
    }
}