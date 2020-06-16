using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App277
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Console.WriteLine("ListView_ItemSelected");
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Console.WriteLine("ListView_ItemTapped");
        }
    }
}
