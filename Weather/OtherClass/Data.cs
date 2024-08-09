using Microsoft.Win32;
using Weather;

namespace Data
{
    public static class Data
    {
        public static string temp;
        public static string humid;
        public static string windir;
        public static string tempfeel;
        public static string windspeed;
        public static string condition;
        public static string place;



    }

    public static class Data2
    {
        public static string apikey;
        public static string star1;
        public static string star2;
        public static string star3;
        public static string star4;
        public static string defloc;

        public static int delay;

        public static bool reginterval;
        public static bool tempchange;

        public static bool firtime;


        public static void Save(string keyname)
        {


            RegistryKey key = Registry.CurrentUser.CreateSubKey(keyname);
            if (key != null)
            {
                //key.SetValue("APIKEY", apikey);
                RegistryKey x = key.CreateSubKey("API");
                RegistryKey y = key.CreateSubKey("defloc");

                RegistryKey s1 = key.CreateSubKey("star1");
                RegistryKey s2 = key.CreateSubKey("star2");
                RegistryKey s3 = key.CreateSubKey("star3");
                RegistryKey s4 = key.CreateSubKey("star4");
                RegistryKey other = key.CreateSubKey("Other");

                x.SetValue("apikey", apikey);
                y.SetValue("defloc", defloc);
                s1.SetValue("star1", star1);
                s2.SetValue("star2", star2);
                s3.SetValue("star3", star3);
                s4.SetValue("star4", star4);

                other.SetValue("delay", delay);
                other.SetValue("regitv", reginterval);
                other.SetValue("tempitv", tempchange);
                other.SetValue("firtime", firtime);

                MessageBox.Show("Updated Parameters", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Failed");
            }

        }

        public static void Load(string keyname)
        {

            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(keyname);
                var api = key.OpenSubKey("API");
                var difloc = key.OpenSubKey("defloc");
                var stir1 = key.OpenSubKey("star1");
                var stir2 = key.OpenSubKey("star2");
                var stir3 = key.OpenSubKey("star3");
                var stir4 = key.OpenSubKey("star4");

                var other = key.OpenSubKey("Other");

                var Apikey = api.GetValue("apikey");
                var Defloc = difloc.GetValue("defloc");
                var st1 = stir1.GetValue("star1");
                var st2 = stir2.GetValue("star2");
                var st3 = stir3.GetValue("star3");
                var st4 = stir4.GetValue("star4");

                var dt = other.GetValue("delay");
                var ret = other.GetValue("regitv");
                var tem = other.GetValue("tempitv");
                var fir = other.GetValue("firtime");

                apikey = Apikey.ToString();
                defloc = Defloc.ToString();
                star1 = st1.ToString();
                star2 = st2.ToString();
                star3 = st3.ToString();
                star4 = st4.ToString();

                delay = Convert.ToInt32(dt);
                reginterval = Convert.ToBoolean(ret);
                tempchange = Convert.ToBoolean(tem);
                firtime = Convert.ToBoolean(fir);
            }
            catch(Exception ex)
            {
                if(ex is NullReferenceException)
                {
                    Application.Run(new Setup());
                }
            }
         


        }
    }

    public static class Data3
    {
        public static string temp1;
        public static string temp2;
        public static string temp3;

        public static string humid1;
        public static string humid2;
        public static string humid3;

        public static string place;
    }
}
