using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukol_4_OOP
{
    class Tahac : NakladniAuto
    {
        public short nosnostPrivesu;
        public Tahac(string spz, short nosnost, short nosnostPrivesu) : base(spz, nosnost)
        {
            this.nosnostPrivesu = nosnostPrivesu;
            this.nosnost += nosnostPrivesu;
        }
    }
}
