using Microsoft.Maui.Controls;
using POLICLINICA_HOPE_.Pages; // Importăm namespace-ul în care se află LoginPage, RegisterPage și CreateAppointmentPage
using System;
using POLICLINICA_HOPE_.ViewModels;


namespace POLICLINICA_HOPE_
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel(); // Setăm ViewModel-ul pentru BindingContext
        }

        // Metodă pentru butonul de Login
        private async void OnLoginClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage()); // Navigăm către LoginPage
        }

        // Metodă pentru butonul de Register
        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage()); // Navigăm către RegisterPage
        }

        // Metodă pentru butonul de Creare Programare
        private async void OnCreateAppointmentClicked(object sender, EventArgs e)
        {
            // Verifică dacă CreateAppointmentPage există înainte de a naviga
            await Navigation.PushAsync(new CreateAppointmentPage());
        }
    }
}
