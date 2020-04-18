using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StateApp.Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageTwo : ContentPage
    {
        public PageTwo()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new PageThree());
        }
    }
}