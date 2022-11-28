using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukol_4_OOP
{
    class NakladniAuto
    {
        string spz;
        short nosnost;
        short HmotnostNakladu { get; }
        public NakladniAuto(string spz, short nosnost)
        {
            this.spz = spz;
            this.nosnost = nosnost;
        }
        public void NalozNaklad(int naklad)
        {

        }
        public void VylozNaklad()
        {

        }
        public override string ToString()
        {
            return spz;
        }
    }
}
