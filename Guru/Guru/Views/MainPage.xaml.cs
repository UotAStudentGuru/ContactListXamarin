using Guru.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xamarin.Forms;

namespace Guru
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            InitializeComponent();
        }
       

        private void NewContact(object sender, EventArgs e)
        {
            
            if (fname.Text.Equals(String.Empty) && surname.Text.Equals(String.Empty) && PhoneNumber.Text.Equals(String.Empty))
            {
                DisplayAlert("Contact", "Κάτι ξέχασες...", "Συνέχεια");
            }
            else
            {
               // Phonebook Person = new Phonebook(fname.Text, surname.Text, PhoneNumber.Text);
                DisplayAlert("Contact", "Εισαγωγη Επιτυχης", "Συνέχεια");
                App.ContactList.Add(new Phonebook { FName = fname.Text, LName = surname.Text, PNumber = PhoneNumber.Text });
            }
        }
       
        private async void MyContacts(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyContacts(), true);
        }
    }
}
