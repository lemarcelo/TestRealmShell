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
    public partial class SegundaView : ContentPage
    {
        public SegundaView()
        {
            InitializeComponent();
            BindingContext = new ViewModels.SegundaViewModel();
        }
    }
}