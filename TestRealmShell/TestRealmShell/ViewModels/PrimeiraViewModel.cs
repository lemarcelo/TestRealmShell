using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Realms;
using Realms.Schema;
using System.ComponentModel;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TestRealmShell.Models;
using System.Linq;

namespace TestRealmShell.ViewModels
{
    public class PrimeiraViewModel
    {
        public string Dados { get; set; }
        public string ParametroOrigem { get; set; }
        public ICommand EnviarCommand => new Command<string>( (route) => Enviar(route));

        void Enviar(string route)
        {
            var realms = Realm.GetInstance();
            realms.Write(() => {
                realms.Add<Models.Model>(new Models.Model { Prop = ParametroOrigem });
            });
            var parametro = realms.All<Model>().Last();
            string joseNewton = JsonConvert.SerializeObject(parametro);

            Shell.Current.GoToAsync($"segunda?entryOrigem={joseNewton}");


        }

    }
}
