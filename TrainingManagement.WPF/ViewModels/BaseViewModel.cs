using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TrainingManagement.WPF.ViewModels.Base
{
    // BẮT BUỘC phải có chữ "public" ở đây nha bri
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}