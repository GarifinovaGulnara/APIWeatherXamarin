using System;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace APIWeatherXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherPage : ContentPage
    {
        CancellationTokenSource cts;
        
        public WeatherPage()
        {
            InitializeComponent();
            var res = GetcurrLocation();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var a = await App.TodoManager.GetTodoItemModels(cityEnterEntry.Text);
            DateTime d = DateTime.Now;
            datetimelbl.Text = d.ToString();
            tempLbl.Text = "t" + " " + a.main.temp.ToString();
            typeweatherlbl.Text = a.weather[0].description;
            feelLikeLbl.Text = "ощущается как" + " " + a.main.feels_like.ToString();
            WindLbl.Text = "направление ветра" + " " + a.wind.gust.ToString();
            HumidityLbl.Text = "влажность" + " " + a.main.humidity.ToString();
            PressureLbl.Text = "давление" + " " + a.main.pressure.ToString();

            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(a.coord.lat, a.coord.lon), Distance.FromMiles(1)));
            Pin pin = new Pin
            {
                Label = a.name,
                Address = "",
                Type = PinType.Place,
                Position = (new Position(a.coord.lat, a.coord.lon))
            };
            MyMap.Pins.Add(pin);
        }

        async Task<Location> GetcurrLocation()
        {
            var request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
            cts = new CancellationTokenSource();
            var location = await Geolocation.GetLocationAsync(request, cts.Token);
            if (location != null)
            {
                MyMap.MoveToRegion (
                    MapSpan.FromCenterAndRadius(new Position (location.Latitude,
                        location.Longitude), Distance.FromKilometers(1))
                        );
            }
            return location;
        }
    }
}