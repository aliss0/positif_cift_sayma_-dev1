using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positif_cift_sayma_ödev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.soru
            Console.WriteLine("1. Soru Çıktısı");
            Console.Write("Lütfen Dizi Uzunluğunu Belirleyiniz : ");
            int diziuzunluk = int.Parse(Console.ReadLine());
            int[] sayidizi = new int[diziuzunluk];
            for (int i = 0; i < diziuzunluk; i++)
            {
                Console.Write("Lütfen {0}. Sayıyı Giriniz: ", i + 1);
                sayidizi[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("**Dizinin içindeki çift sayılar**");
            foreach (int cift in sayidizi)
            {
                if (cift % 2 == 0)
                {
                    Console.WriteLine(cift);
                }
            }


            //2. soru 
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("2. Soru Çıktısı");
            Console.Write("Dizideki Sayılar İle Karşılaştıracağımız Sayıyı Belirleyiniz: ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.Write("Lütfen Dizi Uzunluğunu Belirleyiniz : ");
            int diziuzunluk2 = int.Parse(Console.ReadLine());
            int[] sayidizi2 = new int[diziuzunluk2];
            for (int j = 0; j < diziuzunluk2; j++)
            {
                Console.Write("Lütfen {0}. Sayıyı Giriniz: ", j + 1);
                sayidizi2[j] = int.Parse(Console.ReadLine());

            }
            foreach (int esit in sayidizi2)
            {
                if (esit % sayi2 == 0 || esit == sayi2)
                {
                    Console.WriteLine("----->" + esit);
                }
            }
            // 3.soru
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("3. Soru Çıktısı");
            Console.Write("Kaç Adet Kelime Girmek İstersiniz : ");
            int sayi3 = int.Parse(Console.ReadLine());
            string[] kelime = new string[sayi3];
            for (int a = 0; a < sayi3; a++)
            {
                Console.Write("Lütfen {0}. Kelimeyi Giriniz : ", a + 1);
                kelime[a] = Console.ReadLine();
            }
            Console.WriteLine("**Yazdığınız Kelimelerin Tersten Yazımı**");
            for (int b = (sayi3 - 1); b >= 0; b--)
            {
                Console.WriteLine("Dizinin " + (sayi3 - b) + ". elemanını = " + kelime[b]);
            }

            // 4.soru
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("4. Soru Çıktısı");
            string metin;
            string liste = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"
                           + "abcçdefgğhiıjklmnoöprsştuüvyz";

            int sayac = 0;
            Console.Write("Lütfen Bir Cümle Yazınız : ");
            metin = Console.ReadLine();
            string[] kelimeler = metin.Split(' ');
            Console.WriteLine("Kelime Sayısı :" + (kelimeler.Length));
            for (int c = 0; c < metin.Length; c++)
            {
                //karakter katarkter kontrol ediyoruz.
                if (liste.Contains(metin[c]))
                {
                    sayac++;
                }
            }
            Console.WriteLine("Yukarıdaki ifadede toplam {0} \ntane  harf vardır.", sayac);
            Console.ReadLine();
        }
    }
}
