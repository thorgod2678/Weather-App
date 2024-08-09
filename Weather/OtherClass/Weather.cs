using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Weather
{
    public class Forecast
    {
        public string Temp { get; private set; }
        public string Humidity { get; private set; }
        public string WindDirection { get; private set; }
        public string TempFeel { get; private set; }
        public string WindSpeed { get; private set; }
        public string Condition { get; private set; }

        public Forecast(string temp, string humidity, string windDir, string tempFeel, string windSpeed, string condition)
        {
            this.Temp = temp;
            this.Humidity = humidity;
            this.WindDirection = windDir;
            this.TempFeel = tempFeel;
            this.WindSpeed = windSpeed;
            this.Condition = condition;
        }
    }

    public class WFetcher
    {
        public async Task<Forecast> GetCast(string location)
        {
            HttpClient client = new HttpClient();
            Forecast forecast = null;

            try
            {
                string apiKey = Data.Data2.apikey; // Replace with your actual API key
                string url = $"http://api.weatherapi.com/v1/current.json?key={apiKey}&q={location}";

                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var data = JObject.Parse(content);

                    string temperature = data["current"]["temp_c"].ToString();
                    string humidity = data["current"]["humidity"].ToString();
                    string windDir = data["current"]["wind_dir"].ToString();
                    string tempFeel = data["current"]["feelslike_c"].ToString();
                    string windSpeed = data["current"]["wind_kph"].ToString();
                    string condition = data["current"]["condition"]["text"].ToString();

                    forecast = new Forecast(temperature, humidity, windDir, tempFeel, windSpeed, condition);
                }
                else
                {
                    // Handle unsuccessful response
                    MessageBox.Show($"Failed to fetch weather for {location}", "Illegal Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                client.Dispose();
            }

            return forecast;
        }

        public async Task<Forecast[]> GetWeekCast(string location)
        {
            HttpClient client = new HttpClient();
            Forecast[] ff = null;

            try
            {
                string apiKey = Data.Data2.apikey; // Replace with your actual API key
                string url = $"http://api.weatherapi.com/v1/forecast.json?key={apiKey}&q={location}&days=7";

                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var data = JObject.Parse(content);

                    string temperature1 = data["forecast"]["forecastday"][0]["day"]["avgtemp_c"].ToString();
                    string humidity1 = data["forecast"]["forecastday"][0]["day"]["avghumidity"].ToString();

                    string temperature2 = data["forecast"]["forecastday"][1]["day"]["avgtemp_c"].ToString();
                    string humidity2 = data["forecast"]["forecastday"][1]["day"]["avghumidity"].ToString();

                    string temperature3 = data["forecast"]["forecastday"][2]["day"]["avgtemp_c"].ToString();
                    string humidity3 = data["forecast"]["forecastday"][2]["day"]["avghumidity"].ToString();

                    Forecast forecast1 = new Forecast(temperature1, humidity1, null, null, null, null);
                    Forecast forecast2 = new Forecast(temperature2, humidity2, null, null, null, null);
                    Forecast forecast3 = new Forecast(temperature3, humidity3, null, null, null, null);

                    ff = new Forecast[] { forecast1, forecast2, forecast3 };
                }
                else
                {
                    // Handle unsuccessful response
                    MessageBox.Show($"Failed to fetch weather for {location}", "Illegal Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                client.Dispose();
            }

            return ff;
        }

        public async Task<Forecast> GetICast(string lo)
        {
            if (string.IsNullOrEmpty(lo))
            {
                throw new ArgumentNullException(nameof(lo));
            }

            HttpClient client = new HttpClient();
            Forecast forecast = null;

            try
            {
                string url = "https://api.thingspeak.com/channels/2618240/fields/1.json?api_key=ZAU8GS7C84DARDWW&results=2";

                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var data = JObject.Parse(content);

                    string temperature = data["feeds"]?[0]?["field1"]?.ToString() ?? "Not given";
                    string humidity = data["feeds"]?[0]?["field2"]?.ToString() ?? "Not given";
                    string windDir = "Not given"; // data["channel"]["wind_dir"]?.ToString() ?? "Not given";
                    string tempFeel = "Not given"; // data["channel"]["feelslike_c"]?.ToString() ?? "Not given";
                    string windSpeed = "Not given"; // data["channel"]["wind_kph"]?.ToString() ?? "Not given";
                    string condition = "Not given"; // data["channel"]["condition"]?["text"]?.ToString() ?? "Not given";

                    forecast = new Forecast(temperature, humidity, windDir, tempFeel, windSpeed, condition);
                }
                else
                {
                    // Handle unsuccessful response
                    MessageBox.Show($"Failed to fetch weather for {lo}", "Illegal Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                client.Dispose();
            }

            return forecast;
        }

    }
}
