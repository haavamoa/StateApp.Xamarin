using Xamarin.Forms;

namespace StateApp.Xamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            App.Current.Resources.TryGetValue("State", out var rawState);
            if (rawState is State state)
            {
                state.Initialize();
                State = state;
            }
            MainPage = new NavigationPage(new MainPage());
        }

        public State State { get; }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
