using System;

namespace Deneme
{
    class Program
    {
        // Global Scope Alanı
        

        static void Main(string[] args)
        {
            // Local Scope Alanı

            int sayı1;


                
            Console.WriteLine("Sayıyı Giriniz : ");
            sayı1  = Convert.ToInt32(Console.ReadLine());


            if (sayı1 % 2==0)
            {
                Console.WriteLine("{0} sayısı çift", sayı1);
            }
            else
            {
                Console.WriteLine("{0} sayısı tektir", sayı1);
            }


        }
    }
}
