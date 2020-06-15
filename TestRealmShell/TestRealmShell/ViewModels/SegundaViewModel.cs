using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Realms;
using Xamarin.Forms;
using TestRealmShell.Models;

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
                var jose = JsonConvert.DeserializeObject<Model>(Uri.UnescapeDataString(value));
                App.Current.MainPage.DisplayAlert("", $"{jose.Prop}", "Ok");

            }
        }
    }
}
