using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikListView.Portable.Views;
using TelerikListView.ViewModels;
using Xamarin.Forms;

namespace TelerikListView.Portable
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new TasksViewModel();
        }

        public void Handle_Guage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Guages());
        }
    }
}
