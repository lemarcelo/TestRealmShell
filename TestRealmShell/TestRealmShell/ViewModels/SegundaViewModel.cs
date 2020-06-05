using System;
using System.Collections.Generic;
using System.Text;
using Realms;
using Xamarin.Forms;

namespace TestRealmShell.ViewModels
{
    [QueryProperty("Parametro", "parametro")]
    public class SegundaViewModel
    {
        private string Parametro;

        public string _parametro
        {
            get { return Parametro; }
            set { Uri.UnescapeDataString (value); }
        }

        private string ParametroDestino;

        public string _parametroDestino
        {
            get { return ParametroDestino; }
            set { ParametroDestino = value; }
        }

        public SegundaViewModel()
        {
            ParametroDestino = Parametro;
        }
    }
}
