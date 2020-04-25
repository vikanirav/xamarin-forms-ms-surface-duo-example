using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MSSurfaceDuoDemo.CompanionPane
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompanionPane : ContentPage
    {
        public CompanionPane()
        {
            InitializeComponent();

            List<string> itemList = Enumerable.Range(1, 1000)
                    .Select(i => $"{i}")
                    .ToList();

            listview.ItemsSource = itemList;

            listview.SelectedItem = itemList[0];

        }

        private void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (listview.SelectedItem != null)
            {
                selectedItem.Text = $"{Convert.ToString(listview.SelectedItem)} Selected item";
            }
        }
    }
}