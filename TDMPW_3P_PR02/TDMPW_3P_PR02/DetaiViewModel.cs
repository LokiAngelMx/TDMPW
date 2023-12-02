using System.ComponentModel;
using Microsoft.Maui.Controls;

namespace TDMPW_3P_PR02
{
    public class DetailViewModel : INotifyPropertyChanged
    {
        string _selectedText;
        public string SelectedText
        {
            get => _selectedText;
            set
            {
                if (_selectedText != value)
                {
                    _selectedText = value;
                    OnPropertyChanged(nameof(SelectedText));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}