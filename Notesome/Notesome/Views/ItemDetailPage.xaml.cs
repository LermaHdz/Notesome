using Notesome.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Notesome.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}