using Notesome.ViewModels;
using Xamarin.Forms;
using System;
using Xamarin.Forms.Xaml;

namespace Notesome.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {

        public SignUpPage()
        {
            InitializeComponent();
            this.BindingContext = new SignUpViewModel();
        }
    }
}