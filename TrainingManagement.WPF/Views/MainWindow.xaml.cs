using System.Windows;
using TrainingManagement.WPF.ViewModels;

namespace TrainingManagement.WPF.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Gắn DataContext của toàn bộ cửa sổ này cho MainViewModel.
            // Nếu không có dòng này, mấy cái Binding trong XAML sẽ bị "mù", bấm nút không chạy.
            this.DataContext = new MainViewModel();
        }
    }
}