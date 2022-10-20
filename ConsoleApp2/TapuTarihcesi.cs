using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class TapuTarihcesi
    {
        public Kisi Kisi { get; set; }
        public EdinmeSebebi EdinmeSebebi { get; set; }

        public double EdinmeMiktari { get; set; }

        public DateTime EdinmeTarihi { get; set; }

        public void tarihceToString()
        {            
            Console.Write("Edinme Sebebi : " + (this.EdinmeSebebi == EdinmeSebebi.SatinAlma ? "Satın Alma" : "Miras"));
            Console.Write(" Edinme Tarihi : " + this.EdinmeTarihi.ToShortDateString());
        }
    }
}
