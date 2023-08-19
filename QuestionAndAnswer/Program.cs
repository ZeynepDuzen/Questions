using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionAndAnswer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** kullanicidan personel sayisini ve isimlerini isteyen, bunu konsola yazdiran yapiyi kodlayin ***

            string[] isimler = PersonelIsimleriIste(PersonelSayisi());

            PersonelIsimListesi(isimler);

           

            //PersonelIsimListesi(PersonelIsimleriIste(personelSayisi()));
            


            Console.Read();
        }

        static byte PersonelSayisi()
        {
            Console.WriteLine("Personel sayisini girin :");
            byte personelSayisi = Convert.ToByte(Console.ReadLine());

            return personelSayisi;
        }

        static string[] PersonelIsimleriIste(byte personelSayisi)
        {
            string[] personelIsimleri = new string[personelSayisi];

            for (int i = 0; i < personelSayisi; i++)
            {
                Console.WriteLine(i+1+ ".personelin ismini girin :  ");
                personelIsimleri[i] = Console.ReadLine();
            }
            return personelIsimleri;
        }

        static void PersonelIsimListesi(string[] paramDizi)
        {
            for (int i = 0; i < paramDizi.Length; i++)
            {
                Console.WriteLine(i+1+ ".personel adi : " + paramDizi[i]);
            }
        }
    }
}
