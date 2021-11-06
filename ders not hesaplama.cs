using System;

namespace Deneme
{
    class Program
    {
        // Global Scope Alanı
        

        static void Main(string[] args)
        {
            // Local Scope Alanı

            int vize, final;



            Console.WriteLine("Vize Sınavını Giriniz : ");
            vize  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Final Sınavını Giriniz : ");
            final = Convert.ToInt32(Console.ReadLine());



            int ortalama = (vize * 40 / 100) + (final * 60 / 100);

            if (ortalama >= 50)
            {
                Console.WriteLine("Vize Notun {0} , Final Notun  {1}, Ortalaman ise {2}", vize, final, ortalama);
                Console.WriteLine("Tebrikler. Dersi Geçtin...");
            }
            else
            {
                Console.WriteLine("Vize Notun {0} , Final Notun  {1}, Ortalaman ise {2}", vize, final, ortalama);
                Console.WriteLine("Vay Amk. FF Başarısız..");
            }

            

        }
    }
}
