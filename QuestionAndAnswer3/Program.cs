using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionAndAnswer3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // **  kullanicidan alinacak sayi adeti ve sayilari yazdirip toplayan kod blogu ***

            int[] numbers = SayiListesiIste(SayiAdetiIste());
            SayiListesi(numbers);
            Topla(numbers);


            Console.Read();
        }
        static int SayiAdetiIste()
        {
            Console.WriteLine("Sayi adeti girin : ");
            int sayiAdeti = Convert.ToInt32(Console.ReadLine());
            return sayiAdeti;
        }
        static int[] SayiListesiIste(int sayiAdeti)
        {
            int[] sayilar = new int[sayiAdeti];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(i+1 +  ". sayi : " + sayilar[i]);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            return sayilar;
        }

        static void SayiListesi(int[] paramDizi)
        {
            for (int i = 0; i < paramDizi.Length; i++)
            {
                Console.WriteLine(i+1+". sayi : " + paramDizi[i]);
            }
        }

        static void Topla(int[] numbers)
        {
            int toplam = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                toplam += numbers[i];
            }
            Console.WriteLine("Toplam : " + toplam);
        }
    }
}
