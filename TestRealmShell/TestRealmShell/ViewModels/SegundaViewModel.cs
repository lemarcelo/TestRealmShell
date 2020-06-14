using System;
using System.Collections.Generic;
using System.Text;
using Realms;
using Xamarin.Forms;

namespace TestRealmShell.ViewModels
{
    [QueryProperty("_TextEntryDestino", "entryOrigem")]
    public class SegundaViewModel
    {
        Models.Model model;
        public string _TextEntryDestino
        {
            set
            {
                model = new Models.Model() { Prop = Uri.UnescapeDataString(value) };
                App.Current.MainPage.DisplayAlert("", $"{model.Prop}", "Ok");

            }
        }
    }
}
