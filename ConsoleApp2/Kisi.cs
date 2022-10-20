using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Kisi
    {

        public Kisi()
        {
            TapuListesi = new List<Tapu>();
        }

        //bu sekilde direkt getter setter olusuyor
        //Bilgilere erismek icin sadece getter la erisilebilir
        //Bilgiler update edilmeliyse sadece setter la degistirilebilir

        public int TcKimlikNo { get; set; }
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public int DogumYili { get; set; }

        //Bir kisinin birden fazla tapusu olabilirse tapu listesi lazim kiside.
        //Tapu listesini instantiate etmek gerektigi icin kisinin constructorunda liste create edilir.
        //Boylece bir kisi create edildiginde runner classinda listesi hazir olmus olur, sonra listeye tapular eklenebilir
        public List<Tapu> TapuListesi { get; set; }

        public string kisiToString()
        {
            var sonuc = "";
            for (int i = 0; i < this.Isim.Length; i++)
            {
                if (i == 0)
                {
                    sonuc += this.Isim.ElementAt(i);
                }
                else
                {
                    if (i == this.Isim.Length - 1)
                    {
                        sonuc += this.Isim.ElementAt(i);
                    }
                    else
                    {
                        sonuc += "*";
                    }
                }
            }

            sonuc += " ";

            for (int j = 0; j < this.SoyIsim.Length; j++)
            {
                if (j == 0)
                {
                    sonuc += this.SoyIsim.ElementAt(j);
                }
                else
                {
                    if (j == this.SoyIsim.Length - 1)
                    {
                        sonuc += this.SoyIsim.ElementAt(j);
                    }
                    else
                    {
                        sonuc += "*";
                    }


                }

            }
            
            return sonuc;
        }
    }


}

