using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            BackgroundColor = Constant.BackgroundColor;
            Lbl_Username.TextColor = Constant.MainTextColor;
            Lbl_Password.TextColor = Constant.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LogoIntec.HeightRequest = 120;

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SigninProcedure(s,e);
        }

        void SigninProcedure(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.Checkinfo())
            {
                DisplayAlert("Login", "Login exitoso", "ok");
            }
            else 
            {
                DisplayAlert("Login", "Error, usuario o contraseña en blanco", "ok");
            }
        }
    }
}