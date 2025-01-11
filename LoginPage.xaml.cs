using Microsoft.Maui.Controls;
using POLICLINICA_HOPE_.Data;

namespace POLICLINICA_HOPE_.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var phone = PhoneEntry.Text;
            var password = PasswordEntry.Text;

            using (var context = new AppDbContext())
            {
                var pacient = context.Pacienti.FirstOrDefault(p => p.Telefon == phone && p.Parola == password);
                if (pacient != null)
                {
                    await DisplayAlert("Succes", "Autentificare reușită!", "OK");
                    await Navigation.PushAsync(new MainPage());
                }
                else
                {
                    await DisplayAlert("Eroare", "Date incorecte!", "OK");
                }
            }
        }
    }
}
