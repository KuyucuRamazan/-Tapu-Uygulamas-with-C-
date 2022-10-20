using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Tapu
    {

        public Tapu()
        {
            Tarihce = new List<TapuTarihcesi>();
        }
        public string Ada { get; set; }
        public string Parsel { get; set; }       
        public List<TapuTarihcesi> Tarihce { get; set; }
         internal void tapuAlma(Kisi k, double miktar, EdinmeSebebi edinmeSebebi,DateTime edinmeTarihi)
        {
            var tarihce = new TapuTarihcesi
            {
                EdinmeMiktari = miktar,
                EdinmeSebebi = edinmeSebebi,
                EdinmeTarihi = edinmeTarihi,
                Kisi=k
            };
        
            this.Tarihce.Add(tarihce);
            k.TapuListesi.Append(this);

        }

       

        public string tapuToString()
        {
            return "TAPU Bilgisi Ada " + Ada + " Parsel " + Parsel;
            
        }
    }
}
