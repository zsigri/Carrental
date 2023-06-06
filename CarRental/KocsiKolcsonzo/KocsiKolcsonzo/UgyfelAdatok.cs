using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KocsiKolcsonzo
{
    class UgyfelAdatok
    {
        internal string jogsi, nev, lakcim, tel;

        public UgyfelAdatok(string jogsi, string nev, string lakcim, string tel)
        {
            this.jogsi = jogsi;
            this.nev = nev;
            this.lakcim = lakcim;
            this.tel = tel;
        }
    }
}
