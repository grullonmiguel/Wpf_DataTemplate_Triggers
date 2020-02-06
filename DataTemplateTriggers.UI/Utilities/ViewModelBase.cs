using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataTemplateTriggers.UI.Utilities
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// MultiCast event for property change notifications.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies listeners that a property value has changed.
        /// </summary>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Checks if a property already matches a desired value. Sets 
        /// the property and notifies listeners only when necessary.
        /// </summary>
        protected virtual bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value)) return false;

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}