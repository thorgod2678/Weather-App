namespace Weather
{
    public class Starred
    {
        Forecast final;
        WFetcher wFetcher = new WFetcher();

        public async void SButton(int index, int button, string name)
        {


            if (index == 1)
            {
                if (button == 1)
                {
                    Forecast x = await wFetcher.GetCast(name);

                    if (x != null)
                    {
                        Data.Data.temp = "Temp: " + x.Temp;
                        Data.Data.humid = "Humidity: " + x.Humidity;
                        Data.Data.windir = "Wind Dir: " + x.WindDirection;
                        Data.Data.tempfeel = "What it feels like: " + x.TempFeel;
                        Data.Data.windspeed = "Windspeed: " + x.WindSpeed;
                        Data.Data.condition = "Condition: " + x.Condition;
                        Data.Data.place = "Place: " + name;


                    }

                }

                 if(button == 2)
                {
                    Forecast[] x = await wFetcher.GetWeekCast(name);
                    Data.Data3.temp1 = x[0].Temp;
                    Data.Data3.temp2 = x[1].Temp;
                    Data.Data3.temp3 = x[2].Temp;
                    
                    Data.Data3.humid1 = x[0].Humidity;
                    Data.Data3.humid2 = x[1].Humidity;
                    Data.Data3.humid3 = x[2].Humidity;
                    Data.Data3.place = name;
                }

            }

            if (index == 2)
            {
                if (button == 1)
                {

                    Forecast x = await wFetcher.GetCast(name);

                    if (x != null)
                    {
                        Data.Data.temp = "Temp: " + x.Temp;
                        Data.Data.humid = "Humidity: " + x.Humidity;
                        Data.Data.windir = "Wind Dir: " + x.WindDirection;
                        Data.Data.tempfeel = "What it feels like: " + x.TempFeel;
                        Data.Data.windspeed = "Windspeed: " + x.WindSpeed;
                        Data.Data.condition = "Condition: " + x.Condition;
                        Data.Data.place = "Place: " + name;


                    }

                }

                if (button == 2)
                {
                    Forecast[] x = await wFetcher.GetWeekCast(name);
                    Data.Data3.temp1 = x[0].Temp;
                    Data.Data3.temp2 = x[1].Temp;
                    Data.Data3.temp3 = x[2].Temp;

                    Data.Data3.humid1 = x[0].Humidity;
                    Data.Data3.humid2 = x[1].Humidity;
                    Data.Data3.humid3 = x[2].Humidity;
                    Data.Data3.place = name;
                }
            }
            if (index == 3)
            {
                if (button == 1)
                {
                    Forecast x = await wFetcher.GetCast(name);

                    if (x != null)
                    {
                        Data.Data.temp = "Temp: " + x.Temp;
                        Data.Data.humid = "Humidity: " + x.Humidity;
                        Data.Data.windir = "Wind Dir: " + x.WindDirection;
                        Data.Data.tempfeel = "What it feels like: " + x.TempFeel;
                        Data.Data.windspeed = "Windspeed: " + x.WindSpeed;
                        Data.Data.condition = "Condition: " + x.Condition;
                        Data.Data.place = "Place: " + name;


                    }
                }

                if (button == 2)
                {
                    Forecast[] x = await wFetcher.GetWeekCast(name);
                    Data.Data3.temp1 = x[0].Temp;
                    Data.Data3.temp2 = x[1].Temp;
                    Data.Data3.temp3 = x[2].Temp;

                    Data.Data3.humid1 = x[0].Humidity;
                    Data.Data3.humid2 = x[1].Humidity;
                    Data.Data3.humid3 = x[2].Humidity;
                    Data.Data3.place = name;
                }
            }

            if (index == 4)
            {
                if (button == 1)
                {
                    Forecast x = await wFetcher.GetCast(name);

                    if (x != null)
                    {
                        Data.Data.temp = "Temp: " + x.Temp;
                        Data.Data.humid = "Humidity: " + x.Humidity;
                        Data.Data.windir = "Wind Dir: " + x.WindDirection;
                        Data.Data.tempfeel = "What it feels like: " + x.TempFeel;
                        Data.Data.windspeed = "Windspeed: " + x.WindSpeed;
                        Data.Data.condition = "Condition: " + x.Condition;
                        Data.Data.place = "Place: " + name;


                    }
                }
                if (button == 2)
                {
                    Forecast[] x = await wFetcher.GetWeekCast(name);
                    Data.Data3.temp1 = x[0].Temp;
                    Data.Data3.temp2 = x[1].Temp;
                    Data.Data3.temp3 = x[2].Temp;

                    Data.Data3.humid1 = x[0].Humidity;
                    Data.Data3.humid2 = x[1].Humidity;
                    Data.Data3.humid3 = x[2].Humidity;
                    Data.Data3.place = name;
                }

            }
        }


    }
}
