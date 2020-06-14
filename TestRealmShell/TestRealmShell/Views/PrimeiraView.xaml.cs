using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestRealmShell.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrimeiraView : ContentPage
    {
        public PrimeiraView()
        {
            InitializeComponent();
            //BindingContext = new ViewModels.PrimeiraViewModel();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("segunda?entryOrigem=aa");
        }
    }
}