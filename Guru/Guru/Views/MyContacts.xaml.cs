using Guru.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Guru
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyContacts : ContentPage
    {
      //  ObservableCollection<Phonebook> ContactList = new ObservableCollection<Phonebook>();
      

        public MyContacts()
        {
            InitializeComponent();
            //ContactList.Add(new Phonebook("Thanos", "Kapsalis", "6945181568"));
            ContactList.ItemsSource = App.ContactList;
        }


    }   
}
