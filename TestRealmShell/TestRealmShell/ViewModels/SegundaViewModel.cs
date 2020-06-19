using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Realms;
using Xamarin.Forms;
using TestRealmShell.Models;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TestRealmShell.ViewModels
{
    [QueryProperty("_TextEntryDestino", "entryOrigem")]
    public class SegundaViewModel
    {
        Realm realm = Realm.GetInstance();
        Models.Model model;
        string jose;
        public ICommand EnviarCommand => new Command(async () => await ExibirDados());


        public string _TextEntryDestino
        {
            set
            {
                //var jose = JsonConvert.DeserializeObject<Model>(Uri.UnescapeDataString(value));
                model = new Model { Prop = Uri.UnescapeDataString(value) };
                realm.Write(() => realm.Add(model));

                var personReference = ThreadSafeReference.Create(model);
                jose = realm.ResolveReference(personReference).Prop;
            }
        }



        async Task ExibirDados()
        {
            await App.Current.MainPage.DisplayAlert("", $"{jose}", "Ok");
        }
    }
}

