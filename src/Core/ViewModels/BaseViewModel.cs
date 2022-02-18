using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Core
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler? PropertyChanged;

        #endregion

        #region Protected Methods

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
