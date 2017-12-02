using Start.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Start.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        void SignInProcedure(object sender , EventArgs e)
        {

            
            User user = new User(Entry_Username.Text,Entry_Password.Text);

            if (user.CheckInformation())
            {
                DisplayAlert("Login","Login Success","OK");
            }
            else
            {
                DisplayAlert("Login", "Login not Success User Name ofr Password is empty", "OK");
            }

        }
    }
}