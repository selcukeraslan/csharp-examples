using System;

namespace Deneme
{
    class Program
    {
        // Global Scope Alanı
        

        static void Main(string[] args)
        {
            // Local Scope Alanı

            int sayı1, sayı2;


                
            Console.WriteLine("1. Sayıyı Giriniz : ");
            sayı1  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. Sayıyı Giriniz : ");
            sayı2 = Convert.ToInt32(Console.ReadLine());


            if (sayı1 > sayı2)
            {
                Console.WriteLine("{0} sayısı {1} sayısından büyüktür.. ", sayı1, sayı2);
            }
            else if (sayı2 > sayı1)
            {
                Console.WriteLine("{0} sayısı {1} sayısından büyüktür.. ", sayı2, sayı1);

            }
            else if (sayı1 == sayı2)
            {
                Console.WriteLine("{0} sayısı {1} sayısına Eşittir...", sayı1, sayı2);

            }
            else
            {
                Console.WriteLine("Tuşa düzgün bas AMK");

            }




        }
    }
}
