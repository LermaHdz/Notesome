using Notesome.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Notesome.ViewModels
{
    public class SignUpViewModel : BaseViewModel
    {

        public Command LoginCommandXD { get; }

        public Command SignUpCommand { get; }


        public SignUpViewModel()
        {
            LoginCommandXD = new Command(OnLoginClickedXD);
            SignUpCommand = new Command(OnRegisterClicked);
        }


        private async void OnLoginClickedXD(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }

        private async void OnRegisterClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
