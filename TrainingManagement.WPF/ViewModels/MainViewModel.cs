using System.Windows.Input;
using TrainingManagement.WPF.ViewModels.Base;

namespace TrainingManagement.WPF.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        // 1. Biến lưu trữ ViewModel hiện tại đang được hiển thị
        private BaseViewModel _currentViewModel;

        // 2. Thuộc tính CurrentViewModel để giao diện (XAML) bind vào
        public BaseViewModel CurrentViewModel
        {
            get { return _currentViewModel; }
            set
            {
                _currentViewModel = value;
                // Báo cho giao diện biết là "Ê, màn hình đổi rồi, cập nhật UI đi!"
                OnPropertyChanged();
            }
        }

        // 3. Khai báo các Command (Lệnh) tương ứng với các nút bấm trên Menu
        public ICommand ShowCourseCommand { get; }
        public ICommand ShowPlanCommand { get; }
        public ICommand ShowClassCommand { get; }

        // 4. Constructor: Nơi khởi tạo mặc định khi phần mềm vừa chạy lên
        public MainViewModel()
        {
            // Set màn hình mặc định khi mở app là màn hình Quản lý học phần
            // (Lưu ý: Mấy cái CourseManagerViewModel này bri phải tạo file trống trước thì nó mới không báo lỗi đỏ nha)
            CurrentViewModel = new CourseManagerViewModel();

            // Khởi tạo các lệnh chuyển màn hình
            // Khi bấm nút "Học phần", nó sẽ gán CurrentViewModel thành CourseManagerViewModel mới
            ShowCourseCommand = new RelayCommand(p => CurrentViewModel = new CourseManagerViewModel());

            // Khi bấm nút "Kế hoạch", nó đổi sang màn hình TrainingPlan
            ShowPlanCommand = new RelayCommand(p => CurrentViewModel = new TrainingPlanViewModel());

            // Khi bấm nút "Lớp học", nó đổi sang màn hình CourseOffering (của Dev 3)
            ShowClassCommand = new RelayCommand(p => CurrentViewModel = new CourseOfferingViewModel());
        }
    }

    // --- MẤY FILE DƯỚI ĐÂY LÀ KHUNG TRỐNG ĐỂ TEST CHUYỂN MÀN HÌNH ---
    // Bri tạo 3 file riêng biệt trong thư mục ViewModels nhé, tui để chung đây cho dễ nhìn
    public class CourseManagerViewModel : BaseViewModel { /* Của Dev 2 làm sau */ }
    public class TrainingPlanViewModel : BaseViewModel { /* Của Dev 2 làm sau */ }
    public class CourseOfferingViewModel : BaseViewModel { /* Của Dev 3 làm sau */ }
}