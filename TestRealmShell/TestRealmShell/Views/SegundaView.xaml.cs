using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestRealmShell.Views
{
    [QueryProperty("_TextEntryDestino", "entryOrigem")]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SegundaView : ContentPage
    {
        string a;
        public string _TextEntryDestino
        {
            set
            {
                a = Uri.UnescapeDataString(value);
                Lbl.Text = a;
            }
        }
        public SegundaView()
        {
            InitializeComponent();
            //BindingContext = new ViewModels.SegundaViewModel();
        }
    }
}