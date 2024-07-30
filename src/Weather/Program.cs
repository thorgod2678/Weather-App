using Microsoft.Win32;

namespace Weather
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new ThreadExceptionEventHandler(GlobalExceptionHandler);

            // Add the event handler for handling non-UI thread exceptions
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GlobalExceptionHandler);


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Data.Data2.Load("Weather");

            var x = Registry.CurrentUser.OpenSubKey("Weather");


            if (x==null)
            {
               // Application.Run(new Setup());
            }
            else
            {
                Application.Run(new Form1());
            }
        }

        private static void GlobalExceptionHandler(object sender, ThreadExceptionEventArgs e)
        {
            Error.HandleError(e.Exception);

        }

        private static void GlobalExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject is Exception ex)
            {
                Error.HandleError(ex);
            }
        }
    }
}