using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CMTDeveloperRole.Demo
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetProperty<T>(ref T property, T value, [CallerMemberName] string propName = null)
        {
            if (property != null && property.Equals(value))
                return false;

            property = value;
            NotifyPropertyChanged(propName);

            return true;
        }

        protected void NotifyPropertyChanged([CallerMemberName] string propName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propName));
        }
    }
}