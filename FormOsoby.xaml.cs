using Microsoft.Maui.Controls;
using System;
using form.Model;

namespace form
{
    public partial class FormOsoby : ContentPage
    {
        public FormOsoby()
        {
            InitializeComponent();  
        }

        private void OnZapiszButtonClicked(object sender, EventArgs e)
        {
            string imieINazwisko = ImieINazwiskoEntry.Text;
            string wiek = WiekEntry.Text;
            string adres = AdresEditor.Text;
            string kontakt = KontaktEntry.Text;

            if (string.IsNullOrWhiteSpace(imieINazwisko) || string.IsNullOrWhiteSpace(wiek) ||
                string.IsNullOrWhiteSpace(adres) || string.IsNullOrWhiteSpace(kontakt))
            {
                DisplayAlert("Błąd", "Wszystkie pola muszą być wypełnione!", "OK");
                return;
            }

            if (!int.TryParse(wiek, out int wiekInt) || wiekInt <= 0)
            {
                DisplayAlert("Błąd", "Wiek musi być liczbą większą od zera!", "OK");
                return;
            }

            Osoba osoba = new Osoba
            {
                ImieINazwisko = imieINazwisko,
                Wiek = wiekInt,
                Adres = adres,
                Kontakt = kontakt
            };

            DisplayAlert("Sukces", osoba.FormatujDane(), "OK");
        }
    }
}
