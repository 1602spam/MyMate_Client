using ClientModules.Services;

namespace Jin
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            SvcThread.initializeThreads();
            Application.Run(new Form1());
            Console.Write("test");
        }
    }
}