using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.KazanMYO.VizeFinal.App
{
    class Program
    {
        static void Main(string[] args)
        {//OKAN ERDEM


            Console.WriteLine("Öğrenci sayısı giriniz:");
            byte satir = byte.Parse(Console.ReadLine());

            string[,] ogrenciler = new string[satir + 1, 6];
            ogrenciler[0, 0] = "Ad";
            ogrenciler[0, 1] = "Soyad";
            ogrenciler[0, 2] = "Vize";
            ogrenciler[0, 3] = "Final";
            ogrenciler[0, 4] = "Ortalama";
            ogrenciler[0, 5] = "HarfNotu";


            int vize;
            int final;
            double ortalama;

            for (int i = 1; i < ogrenciler.GetLength(0); i++)
            {
                Console.WriteLine("Öğrenci Adı Giriniz:");
                ogrenciler[i, 0] = Console.ReadLine();

                Console.WriteLine("Öğrenci Soyadı Giriniz:");
                ogrenciler[i, 1] = Console.ReadLine();

                Console.WriteLine("Vize Notunu Giriniz:");
                ogrenciler[i, 2] = Console.ReadLine();
                vize = Convert.ToInt32(ogrenciler[i, 2]);

                Console.WriteLine("Final Notunu Giriniz:");
                ogrenciler[i, 3] = Console.ReadLine();
                final = Convert.ToInt32(ogrenciler[i, 3]);
                
                ogrenciler[i, 4] = $"{ortalama = (vize * 0.4) + (final * 0.6)}";

                if (ortalama >= 0 && ortalama < 40)
                {
                    ogrenciler[i, 5] = "\t FF";
                }
                if (ortalama >= 40 && ortalama < 50)
                {
                    ogrenciler[i, 5] = "\t FD";
                }
                if (ortalama >= 50 && ortalama < 55)
                {
                    ogrenciler[i, 5] = "\t DD";
                }
                if (ortalama >= 55 && ortalama < 60)
                {
                    ogrenciler[i, 5] = "\t DC";
                }
                if (ortalama >= 60 && ortalama < 70)
                {
                    ogrenciler[i, 5] = "\t CC";
                }
                if (ortalama >= 70 && ortalama < 80)
                {
                    ogrenciler[i, 5] = "\t CB";
                }
                if (ortalama >= 80 && ortalama < 85)
                {
                    ogrenciler[i, 5] = "\t BB";
                }
                if (ortalama >= 85 && ortalama < 90)
                {
                    ogrenciler[i, 5] = "\t BA";
                }
                if (ortalama >= 90 && ortalama <= 100)
                {
                    ogrenciler[i, 5] = "\t AA";
                }
                
            }


            
            for (int i = 0; i < ogrenciler.GetLength(0); i++)
            {

                for (int j = 0; j < ogrenciler.GetLength(1); j++)
                {
                    Console.Write(ogrenciler[i, j] +"\t");
                }
                Console.WriteLine();
            }





        }


    }
}
