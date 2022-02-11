using App1.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.Viewmodels
{
    public class ViewmodelPage2 : INotifyPropertyChanged
    {

        private int _int = 1000;

        public int IncInt
        {
            get => _int;
            set
            {
                _int = value;
                OnPropertyChanged();
            }
        }

        public async Task ChangeInt()
        {
            await Task.Delay(500);
            _int += 1;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICommand LabelCommand => new Command(async Value =>
        {
            await ChangeInt();
        });

        public ICommand Command => new Command(async Value =>
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Page1());
        });


    }
}
