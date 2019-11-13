using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Blazorius.Charts.Peity.Models
{
    public class OptionsBase : INotifyPropertyChanged
    {
        private int? height;
        private int? width;
        private string[] fill;
        private string delimiter = ",";

        public string Delimiter { get => delimiter; set => SetProperty(ref delimiter, value); }

        public string[] Fill { get => fill; set => SetProperty(ref fill, value); }

        public int? Height { get => height; set => SetProperty(ref height, value); }

        public int? Width { get => width; set => SetProperty(ref width, value); }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises <see cref="PropertyChanged"/> event with called member name.
        /// </summary>
        /// <param name="memberName">Caller member name.</param>
        public void OnPropertyChanged([CallerMemberName]string memberName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));


        protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName]string propertyName = "", Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
