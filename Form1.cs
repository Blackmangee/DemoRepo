using Newtonsoft.Json;
using System;
using System.Net;
using System.Windows.Forms;
//using System.Net;

namespace Weather_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string APIKey = Environment.GetEnvironmentVariable("Open_WeatherAPIKey");
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
            getForecast();
        }


        double lon;
        double lat;
        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                //string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q=(0)&appid=(1)", TBCity.Text, APIKey);
                string url = "https://api.openweathermap.org/data/2.5/weather?q=Lagos&appid=f24714db7a0152bcf7513b88b9201d37";
                var Json = web.DownloadString(url);
                Weatherinfo.root info = JsonConvert.DeserializeObject<Weatherinfo.root>(Json);

                picIcon.ImageLocation = "https://openweathermap.org/img/w/" + info.weather[0] + ".png";

                labCondition.Text = info.weather[0].main;
                labDetails.Text = info.weather[0].description;
                labSunset.Text = convertDateTime(info.sys.sunset).ToShortTimeString();
                labSunrise.Text = convertDateTime(info.sys.sunrise).ToShortTimeString();

                labWindSpeed.Text = info.wind.speed.ToString();
                labPressure.Text = info.main.pressure.ToString();

                lon = info.coord.lon;
                lat = info.coord.lat;

            }
        }
        DateTime convertDateTime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();

            return day;
        }
        void getForecast()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/3.0/onecall?lat=33.44&lon=-94.04&units=metric&exclude=current,minutely,hourly,alerts&appid=f24714db7a0152bcf7513b88b9201d37", lon, lat, APIKey);
                //string url = "https://api.openweathermap.org/data/3.0/onecall?lat=33.44&lon=-94.04&exclude=current,minutely,hourly,alerts&appid=f24714db7a0152bcf7513b88b9201d37";
                //string url = string.Format("https://api.openweathermap.org/data/3.0/onecall?lat=(0)&lon=-(1)&exclude=current,minutely,hourly,alerts&appid=(2)", lon, lat, APIKey);
                // string url = "https://api.openweathermap.org/data/2.5/weather?q=Lagos&appid=f24714db7a0152bcf7513b88b9201d37";
                var Json = web.DownloadString(url);
                WeatherForecast.forecastInfo forecastInfo = JsonConvert.DeserializeObject<WeatherForecast.forecastInfo>(Json);

                ForecastUC FUC;
                for (int i = 0; i < 8; i++)
                {
                    FUC = new ForecastUC();
                    FUC.picWeatherIcon.ImageLocation = "https://openweathermap.org/img/w/" + forecastInfo.daily[i].weather[0].icon + ".png";
                    FUC.labMainWeather.Text = forecastInfo.daily[i].weather[0].main;
                    FUC.labWeatherDescription.Text = forecastInfo.daily[i].weather[0].description;
                    FUC.labDT.Text = convertDateTime(forecastInfo.daily[i].dt).DayOfWeek.ToString();
                    FUC.labTemperature.Text = forecastInfo.daily[i].temp.day.ToString();
                        
                    FLP.Controls.Add(FUC);
                }

            }
        }
    }
}
