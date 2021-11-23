using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co2BesparelseWindows
{
    internal class Koordinatberegner
    {
        private string key;

        public Koordinatberegner(string key)
        {
            this.key = key;
        }

        public async Task<Koordinatset> HentKoordinaterForAdresse(string adresse)
        {
            return await AfstandService.AdresseTilKoordinater(key, adresse);            
        }
    }
}
