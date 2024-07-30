namespace Weather.OtherClass
{
    public class Notifications

    {

        public Notifications(NotifyIcon noti) { NotifyIcon = noti; }

        private NotifyIcon NotifyIcon;
        // Forecast fore = new Forecast(null, null, null, null, null, null);
        WFetcher wFetcher = new WFetcher();
        public void SendNotification(string msg, string title, int time)
        {


            NotifyIcon.Visible = true;
            NotifyIcon.BalloonTipTitle = title;
            NotifyIcon.BalloonTipText = msg;
            NotifyIcon.ShowBalloonTip(time * 1000, title, msg, ToolTipIcon.Info); // Convert seconds to milliseconds
        }

        public async void ShowNotifications(string place)
        {
            Forecast x = await wFetcher.GetCast(place);

            if (x != null)
            {
                Data.Data.temp = "Temp: " + x.Temp;
                Data.Data.humid = "Humidity: " + x.Humidity;
                Data.Data.windir = "Wind Dir: " + x.WindDirection;
                Data.Data.tempfeel = "What it feels like: " + x.TempFeel;
                Data.Data.windspeed = "Windspeed: " + x.WindSpeed;
                Data.Data.condition = "Condition: " + x.Condition;
                Data.Data.place = "Place: " + place;


            }

            SendNotification($"Is The Temprature in {place} the humidity is {x.Humidity}", x.Temp, 60 * 60);
        }

        public void PassiveNotifications(int interval)
        {
            PassiveNotif x = new PassiveNotif();
            x.Start(interval, () => ShowNotifications(Data.Data2.defloc));
        }

    }

    public class PassiveNotif
    {
        private System.Timers.Timer _timer;

        public void Start(int intervalInSeconds, Action action)
        {
            _timer = new System.Timers.Timer(intervalInSeconds * 1000);
            _timer.Elapsed += (sender, e) => action();
            _timer.AutoReset = true;
            _timer.Enabled = true;
        }

        public void Stop()
        {
            if (_timer != null)
            {
                _timer.Stop();
                _timer.Dispose();
                _timer = null;
            }
        }
    }
}
