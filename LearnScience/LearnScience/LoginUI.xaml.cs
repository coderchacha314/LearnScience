using LearnScience.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearnScience
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginUI : ContentPage
    {
        private SQLiteConnection conn;
        public Registration registration;
        public LoginUI()
        {
            InitializeComponent();
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Registration>();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {


            if (txtUsername.Text== "admin" && txtPassword.Text == "123456")
            {
                Navigation.PushAsync(new HomePage());
            }
            else
            {
                DisplayAlert("Incorrect Credentials", "Enter Correct Username and Password", "ok");
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());

        }

    }
}