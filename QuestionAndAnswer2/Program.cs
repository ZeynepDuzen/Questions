using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionAndAnswer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanicidan alinan sayi adetini ve sayilari ekrana yazdirin
            int[] numbers = SayiListesiIste(SayiAdetiIste());
            SayilariListele(numbers);

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
                Console.WriteLine(i + 1 + ".sayiyi girin : ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            return sayilar;
        }

        static void SayilariListele(int[] paramDizi)
        {
            for (int i = 0; i < paramDizi.Length; i++)
            {
                Console.WriteLine(i+1+ ".sayi : " + paramDizi[i]);
            }
        }
    }
}
