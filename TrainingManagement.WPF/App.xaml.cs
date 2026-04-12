using System.Configuration;
using System.Data;
using System.Windows;
using TrainingManagement.WPF.Data;
using TrainingManagement.WPF.ViewModels;
using TrainingManagement.WPF.Views;

namespace TrainingManagement.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Khởi tạo DbContext
            using (var context = new AppDbContext())
            {
                // Gọi hàm Seed Data
                SeedData.Initialize(context);
            }

            // Khởi tạo MainWindow
            var mainWindow = new MainWindow
            {
                DataContext = new MainViewModel()
            };
            mainWindow.Show();
        }
    }

}
