/*
 * Created Date: 2022-06-29 (Wed)
 * Author: Doyun Jung (Á¤µµÀ±) / rabbit.white@daum.net
 * Subject: Program
 * Filename: Program.cs
 * Description:
 * - 1. 
 */
namespace SmartLogistics
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
            Application.Run(new MainFrm());
        }
    }
}