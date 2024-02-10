

//210229048_İzzetEsener

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARABALAR
{
    internal class Araba
    {

        public string Marka { get; set; }

        public string Model { get; set; }
        public string Paket { get; set; }
        public string Paket2 { get; set; }
        public Dictionary<string, int> Paket1Parcalar { get; set; }
        public Dictionary<string, int> Paket2Parcalar { get; set; }


        public Araba(string marka = "", string model = "", string paket = "", string paket2 = "", Dictionary<string, int> parcalarPaket1 = null, Dictionary<string, int> parcalarPaket2 = null)
        {
            this.Marka = marka;
            this.Model = model;
            this.Paket = paket;
            this.Paket2 = paket2;
            this.Paket1Parcalar = parcalarPaket1;
            this.Paket2Parcalar = parcalarPaket2;

        }

    }
}
