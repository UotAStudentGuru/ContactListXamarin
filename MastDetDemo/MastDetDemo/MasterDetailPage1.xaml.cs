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
    public partial class MasterDetailPage1 : MasterDetailPage
    {
        public MasterDetailPage1()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterDetailPage1MenuItem;
            if (item == null)
                return;


            if (item.Title.Equals("Add Contact"))
            {

             await Navigation.PushAsync(new AddContact_page(),true);
                
            }
            else if (item.Title.Equals("View Contacts"))
            {

                await Navigation.PushAsync(new ViewContacts_page(),true);
            }

        MasterPage.ListView.SelectedItem = null;

            
        }
    }
}