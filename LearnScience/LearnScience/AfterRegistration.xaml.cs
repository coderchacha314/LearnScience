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
    public partial class AfterRegistration : ContentPage
    {
        private SQLiteConnection conn;
        public Registration registration;
        public AfterRegistration()
        {
            InitializeComponent();
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Registration>();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var data = (from reg in conn.Table<Registration>() select reg);
            Datalist.ItemsSource = data;
        }

        private void TapGestureRecognizer_Login(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginUI());
        }
    }
}