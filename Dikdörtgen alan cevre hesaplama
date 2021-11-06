using System;

namespace Deneme
{
    class Program
    {
        // Global Scope Alanı
        

        static void Main(string[] args)
        {
            // Local Scope Alanı

            double KısaKenar, UzunKenar;



            Console.WriteLine("Kısa Kenarı Giriniz : ");
            KısaKenar  = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Uzun Kenarı Giriniz : ");
            UzunKenar = Convert.ToDouble(Console.ReadLine());

            while (KısaKenar > UzunKenar) // Eğer Kısa Kenar, Uzun Kenardan Büyükse Yanlış. Küçük olana kadar tekrar sor.
            {
                Console.WriteLine("Kısa Kenarı Giriniz : ");
                KısaKenar = Convert.ToDouble(Console.ReadLine());
            }

            double alan = KısaKenar * UzunKenar;
            double cevre = (2 * KısaKenar) + (2 * UzunKenar);

            Console.WriteLine("Alan : {0} ve Çevre : {1}", alan, cevre);

        }
    }
}
