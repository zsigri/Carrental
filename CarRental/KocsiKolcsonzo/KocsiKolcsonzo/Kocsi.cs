using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KocsiKolcsonzo
{
    class Kocsi
    {
        internal string rendszam, marka, tipus, uzemanyag, leiras;
        internal int terfogat, kilometer, napidij, stat;
        internal DateTime muszaki;

        public Kocsi(string ren, string mar, string tip, int ter, string uze, int kil, DateTime musz, int napi, string lei, int stat)
        {
            rendszam = ren;
            marka = mar;
            tipus = tip;
            terfogat = ter;
            uzemanyag = uze;
            kilometer = kil;
            muszaki = musz;
            napidij = napi;
            leiras = lei;
            this.stat = stat;
        }
    }
}
