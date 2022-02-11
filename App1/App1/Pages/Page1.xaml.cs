using App1.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        private ViewmodelPage1 viewmodel = new ViewmodelPage1();
        public Page1()
        {
            InitializeComponent();
            BindingContext = viewmodel;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await viewmodel.ChangeInt();
        }
    }
}