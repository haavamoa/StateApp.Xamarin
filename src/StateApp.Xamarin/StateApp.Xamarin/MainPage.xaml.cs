using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace StateApp.Xamarin
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

        private void Button_OnClicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new PageTwo());
        }

        private void ChangeTheState(object sender, EventArgs e)
        {
            ((App)Application.Current).State.StatefulObject.SharedString = "Updated state from C#";
        }
    }
}
