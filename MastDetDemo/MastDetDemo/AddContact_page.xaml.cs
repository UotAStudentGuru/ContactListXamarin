using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MastDetDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddContact_page : ContentPage
    {
        public AddContact_page()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, true);

        }

        private void Add_OnClicked(object sender, EventArgs e)
        {
            if (fname.Text.Equals(string.Empty) || surname.Text.Equals(string.Empty) || PhoneNumber.Text.Equals(string.Empty))
            {
                DisplayAlert("Contact", "Κάτι ξέχασες...", "Συνέχεια");
            }
            else if (!fname.Text.Equals(string.Empty) && !surname.Text.Equals(string.Empty) && !PhoneNumber.Text.Equals(string.Empty))
            {
                // Phonebook Person = new Phonebook(fname.Text, surname.Text, PhoneNumber.Text);
                DisplayAlert("Contact", "Εισαγωγη Επιτυχης", "Συνέχεια");
                App.ContactList.Add(new Contact { FName = fname.Text, LName = surname.Text, PNumber = PhoneNumber.Text });
            }
        }

        private async void Display_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new ViewContacts_page()));
        }
    }
}