using System;

namespace Not_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Not Girin: ");

            double not = double.Parse(Console.ReadLine());


            if (not >= 0 && not >= 100)
            {
                Console.WriteLine("Lütfen 1 ila 100 arasında bir değer girin");
            }
            else if (not <= 49)
            {
                Console.WriteLine("Başarısız");
            }
            else if (not <= 64)
            {
                Console.WriteLine("Orta");
            }
            else if (not <= 84)
            {
                Console.WriteLine("İyi");
            }
            else if (not <= 100)
            {
                Console.WriteLine("Çok İyi");
            }
        }
    }
}
