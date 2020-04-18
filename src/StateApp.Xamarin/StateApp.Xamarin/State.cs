using System.ComponentModel;
using DIPS.Xamarin.UI.Extensions;

namespace StateApp.Xamarin
{
    public class State
    {
        public void Initialize()
        {
            //Dependency inject stuff from container if you need to?
            StatefulObject = new StatefulObject();
        }

        public StatefulObject StatefulObject { get; private set; }  
        
    }

    public class StatefulObject : INotifyPropertyChanged
    {
        private string m_sharedString;

        public string SharedString
        {
            get => m_sharedString;
            set => PropertyChanged.RaiseWhenSet(ref m_sharedString, value);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}