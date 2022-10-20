using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisi basrol = new Kisi();
            basrol.Isim = "Sadik";
            basrol.SoyIsim = "Kural";
            basrol.TcKimlikNo = 1;

            Kisi kisi2 = new Kisi();
            kisi2.Isim = "Ahmet";
            kisi2.SoyIsim = "Bayram";
            kisi2.TcKimlikNo = 2;

            Kisi kisi3 = new Kisi();
            kisi3.Isim = "Süleyman";
            kisi3.SoyIsim = "Kocak";
            kisi3.TcKimlikNo = 3;

            Kisi kisi4 = new Kisi();
            kisi4.Isim = "Ali";
            kisi4.SoyIsim = "Koç";
            kisi4.TcKimlikNo = 4;


            Kisi kisi5 = new Kisi();
            kisi5.Isim = "Mehmet";
            kisi5.SoyIsim = "Kus";
            kisi5.TcKimlikNo = 5;

            Kisi kisi6 = new Kisi();
            kisi6.Isim = "Zafer";
            kisi6.SoyIsim = "Kose";
            kisi6.TcKimlikNo = 6;

            Kisi kisi7 = new Kisi();
            kisi7.Isim = "Ridvan";
            kisi7.SoyIsim = "Unal";
            kisi7.TcKimlikNo = 7;

            List<Tapu> tapular = new List<Tapu>();


            Tapu arsa1 = new Tapu();
            //TODO ada parsel de yaz
            arsa1.Ada = "1";
            arsa1.Parsel = "200";

            arsa1.tapuAlma(kisi2, 10000.00, EdinmeSebebi.SatinAlma, new DateTime(2022, 6, 5));
            arsa1.tapuAlma(kisi3, 10000.00, EdinmeSebebi.SatinAlma, new DateTime(2021, 6, 5));
            arsa1.tapuAlma(kisi4, 10000.00, EdinmeSebebi.SatinAlma, new DateTime(2021, 6, 5));
            arsa1.tapuAlma(kisi5, 10000.00, EdinmeSebebi.SatinAlma, new DateTime(2020, 6, 5));
            arsa1.tapuAlma(kisi6, 10000.00, EdinmeSebebi.SatinAlma, new DateTime(2020, 6, 5));
            arsa1.tapuAlma(kisi7, 10000.00, EdinmeSebebi.SatinAlma, new DateTime(2020, 6, 5));
            arsa1.tapuAlma(basrol, 10000.00, EdinmeSebebi.SatinAlma, new DateTime(2018, 6, 5));
            tapular.Add(arsa1);
            Tapu arsa2 = new Tapu();

            arsa2.tapuAlma(kisi2, 20000.00, EdinmeSebebi.SatinAlma, new DateTime(2022, 6, 5));
            arsa2.tapuAlma(kisi3, 20000.00, EdinmeSebebi.SatinAlma, new DateTime(2021, 6, 5));
            arsa2.tapuAlma(kisi4, 20000.00, EdinmeSebebi.SatinAlma, new DateTime(2021, 6, 5));
            arsa2.tapuAlma(basrol, 20000.00, EdinmeSebebi.SatinAlma, new DateTime(2020, 6, 5));
            tapular.Add(arsa2);



            Tapu arsa3 = new Tapu();
            arsa3.tapuAlma(basrol,0,EdinmeSebebi.Miras, new DateTime(2015, 6, 5));
            tapular.Add(arsa3);

            Console.Write("Sorgulama için Tc Kimlik No giriniz : ");
            var tcKimlikNoString = Console.ReadLine();
            var tcKimlikNo = Convert.ToInt32(tcKimlikNoString);

            foreach (var tapu in tapular)
            {
                for (int i = 0; i < tapu.Tarihce.Count; i++)
                {
                    var tarihce = tapu.Tarihce[i];
                    
                    if (tarihce.Kisi.TcKimlikNo== tcKimlikNo)
                    {                        
                        Console.Write(tarihce.Kisi.kisiToString());
                        Console.Write(" " + tapu.tapuToString());
                        Console.Write(" Kaçıncı Sahibi : " + (i + 1)+" ");
                        tarihce.tarihceToString();


                        for (int ii = i-1; ii >= 0; ii--)
                        {
                            Console.WriteLine();
                            var eskiSahibi = tapu.Tarihce[ii];                                                  
                            Console.Write(eskiSahibi.Kisi.kisiToString());
                            if(ii==0)
                            Console.Write(" İlk Sahibi : " + (ii + 1) + " ");
                            else
                                Console.Write(" Kaçıncı Sahibi : " + (ii + 1) + " ");
                            eskiSahibi.tarihceToString();
                        }
                        Console.WriteLine(" ");
                    }

                }


            }

            Console.ReadLine();
        }
    }
}
