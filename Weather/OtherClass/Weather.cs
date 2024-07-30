using Newtonsoft.Json.Linq;

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
                    MessageBox.Show($"Failed to fetch weather for {location}");
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

