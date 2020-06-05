using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Realms;

namespace TestRealmShell.ViewModels
{
    public class PrimeiraViewModel
    {
        public string Dados { get; set; }
        public string ParametroOrigem { get; set; }
        public ICommand EnviarCommand => new Command(() => EnviarCommand());

        private void EnviarCommand()
        {
            throw new NotImplementedException();
        }

    }
}
