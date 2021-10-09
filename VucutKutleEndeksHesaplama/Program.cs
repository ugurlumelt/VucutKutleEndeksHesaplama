using System;

namespace VucutKutleEndeksHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vücut kütle endeksi hesaplaması için lütfen bilgilerinizi giriniz.");

            Console.WriteLine("Kilonuz :");
            double kilo = double.Parse(Console.ReadLine());

            Console.WriteLine("Boyunuz :");
            double boy = double.Parse(Console.ReadLine());

            double result = kilo / (boy * boy);

            if (result < 18.49)
            {
                Console.WriteLine("Sonuca göre İdeal kilonun altındasınız ." + result);
            }
            else if (  result< 25 )
            {
                Console.WriteLine("Sonuca göre İdeal kilodasınız." + result);
            }
            else if (result < 30)
            {
                Console.WriteLine("Sonuca göre İdeal kilonun üzerindesiniz." + result);
            }
            else 
            {
                Console.WriteLine("Sonuca göre İdeal kilonun çok çok üzerindesiniz ." + result);
            }
        }
    }
}
