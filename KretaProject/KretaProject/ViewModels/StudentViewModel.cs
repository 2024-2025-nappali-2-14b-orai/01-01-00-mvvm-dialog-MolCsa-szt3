using CommunityToolkit.Mvvm.ComponentModel;
using KretaProject.Models;

namespace KretaProject.ViewModels
{
    public partial class StudentViewModel : ObservableObject
    {
        [ObservableProperty]
        private Student _student=new Student();
    }
}
