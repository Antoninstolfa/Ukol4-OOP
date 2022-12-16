using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukol_4_OOP
{
    class NakladniAuto
    {
        public string spz;
        public short nosnost;
        short hmotnostnakladu = 0;
        public short HmotnostNakladu
        {
            get
            {
                return hmotnostnakladu;
            }
        }
        public NakladniAuto(string spz, short nosnost)
        {
            this.spz = spz;
            this.nosnost = nosnost;
        }
        public void NalozNaklad(short naklad)
        {
            if (naklad > nosnost)
            {
                hmotnostnakladu = nosnost;
                MessageBox.Show("Náklad převažuje maximální nosnost vozidla, Bylo naloženo jenom " + naklad.ToString() + " tun." + (naklad - nosnost).ToString() + "nelze už naložit");
            }
            else
            {
                MessageBox.Show("Náklad byl naložen.");
                hmotnostnakladu += naklad;
            }
        }
        public void VylozNaklad(short vyloz)
        {
            if (vyloz > hmotnostnakladu)
            {
                MessageBox.Show("Náklad byl vložen, ale chybí " + (vyloz - hmotnostnakladu).ToString() + " tun písku");
                hmotnostnakladu = 0;
            }
            else
            {
                MessageBox.Show("Náklad byl yložen.");
                hmotnostnakladu -= vyloz;
            }
        }
        public override string ToString()
        {
            return "Nákladní auto " + spz + " má nosnost " + nosnost.ToString() + " tun a má naloženo " + hmotnostnakladu.ToString() + " tun písku";
        }
    }
}
