using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionAndAnswer4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int personelSayisi = PersonelSayisiIste();
            string[] isimler = PersonelIsmiIste(personelSayisi);
            int[] yaslar = YasIste(isimler);
            double[] maaslar = MaasIste(isimler);

            PersonelTumListe(isimler,maaslar,yaslar);
            

            Console.Read();
        }
        static int PersonelSayisiIste()
        {
            Console.WriteLine("Personel sayisi girin : ");
            int personelSayisi = Convert.ToInt32(Console.ReadLine());
            return personelSayisi;
        }

        static string[] PersonelIsmiIste(int personelSayisi)
        {
            string[] personeller = new string[personelSayisi];
            for (int i = 0; i < personeller.Length; i++)
            {
                Console.WriteLine(i+1+".Personelin ismini girin : ");
                personeller[i] = Console.ReadLine();
            }
            return personeller;
        }

        static int[] YasIste(string[] personeller)
        {
            int[] yaslar = new int[personeller.Length];
            for (int i = 0; i < yaslar.Length; i++)
            {
                Console.WriteLine(i+1+".personelin yasi : ");
                yaslar[i] = Convert.ToInt32(Console.ReadLine());
            }
            return yaslar;
        }

        static double[] MaasIste(string[] personeller)
        {
            double[] maaslar = new double[personeller.Length];
            for (int i = 0; i < personeller.Length; i++)
            {
                Console.WriteLine(i+1+".personelin mmasini girin : ");
                maaslar[i] = Convert.ToInt32(Console.ReadLine());
            }
            return maaslar;

        }

        
        static void PersonelTumListe(string[] personeller, double[] maaslar, int[] yaslar)
        {
            Console.WriteLine("adi\tYasi\tMaasi");

            for (int i = 0; i < personeller.Length; i++)
            {
                Console.WriteLine(personeller[i] + "\t" + yaslar[i] + "\t" + maaslar[i]);
            }
        }
        
    }
}
