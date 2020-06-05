using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Realms;
using Realms.Schema;
using System.ComponentModel;
using System.Threading.Tasks;

namespace TestRealmShell.ViewModels
{
    public class PrimeiraViewModel
    {
        public string Dados { get; set; }
        public string ParametroOrigem { get; set; }
        public ICommand EnviarCommand => new Command<string>( async (route) => await Enviar(route));

        async Task Enviar(string route)
        {
            var realms = Realm.GetInstance();
            realms.Write(() => {
                realms.Add<models.Model>(new models.Model { Prop = ParametroOrigem });
            });

            await Shell.Current.GoToAsync($"segunda?parametro={route}") ;


        }

    }
}
