using EFWindowsForm.Data;
using Microsoft.Extensions.DependencyInjection;

namespace EFWindowsForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var serviceProvider = DependencyContainer.ConfigureServices();

            Application.Run(serviceProvider.GetRequiredService<Form1>());
        }
    }
}