using Notesome.ViewModels;
using Xamarin.Forms;

namespace Notesome.Views
{
    public partial class SharedPage : ContentPage
    {
        public SharedViewModel ViewModel { get; set; }

        public SharedPage()
        {
            InitializeComponent();
            ViewModel = new SharedViewModel();
            BindingContext = ViewModel;
        }
    }
}
