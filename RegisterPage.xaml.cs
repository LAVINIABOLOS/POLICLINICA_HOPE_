using Microsoft.Maui.Controls;
using POLICLINICA_HOPE_.Data; // Import pentru AppDbContext
using POLICLINICA_HOPE_.Models; // Import pentru Pacient

namespace POLICLINICA_HOPE_.Pages
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            var pacient = new Pacient
            {
                Nume = NameEntry.Text,
                Prenume = SurnameEntry.Text,
                Telefon = PhoneEntry.Text,
                Parola = PasswordEntry.Text,
                DataNasterii = BirthDatePicker.Date,
                Sex = SexPicker.SelectedItem.ToString()
            };

            using (var context = new AppDbContext())
            {
                context.Pacienti.Add(pacient);
                await context.SaveChangesAsync();
            }

            await DisplayAlert("Succes", "Înregistrare reușită!", "OK");
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
