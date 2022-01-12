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
    public partial class RegisterPage : ContentPage
    {
        private SQLiteConnection conn;
        public Registration registration;

        public RegisterPage()
        {
            InitializeComponent();
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Registration>();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            registration = new Registration();
            registration.name = txtName.Text;
            registration.mobile =int.Parse( txtMobile.Text);
            registration.email = txtEmail.Text;
            registration.password = txtPassword.Text;
            conn.Insert(registration);
            txtName.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            Navigation.PushAsync(new AfterRegistration());


        }
    }
}