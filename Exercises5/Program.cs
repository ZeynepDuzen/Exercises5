using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** 2 adet rastgele sayi tutalim ***
            //Random rdm = new Random(); //nesne uretildi

            //int sayi1 = rdm.Next(10,20);
            //int sayi2 = rdm.Next(5, 10);

            //Console.WriteLine("1. rastgele sayinizin degeri : " + sayi1);
            //Console.WriteLine("2. rastgele sayinizin degeri : " + sayi2);

            // *** 3 adet rastgele sayi tutalim ***
            //Random biSayiTut = new Random();

            //int sayi1 = biSayiTut.Next(1,6);
            //int sayi2 = biSayiTut.Next(5,11);
            //int sayi3 = biSayiTut.Next(10,16);

            //Console.WriteLine("1. rastgele sayinizin degeri : " + sayi1);
            //Console.WriteLine("2. rastgele sayinizin degeri : " + sayi2);
            //Console.WriteLine("3. rastgele sayinizin degeri : " + sayi3);

            //fb ve gs icin 0-3 arası rastgele bi sayi tutulsun, beraberlik veya üstünlük durumlari if-else ile belirtilsin

            Random mac = new Random();

            int fb = mac.Next(0,3);
            int gs = mac.Next(0,3);

            if (fb == gs)
            {
                Console.WriteLine("Berabere");
                Console.WriteLine("fb skor : " + fb);
                Console.WriteLine("gs skor : " + gs);
            }
            else if (fb>gs)
            {
                Console.WriteLine("Fenerbahce is the winner");
                Console.WriteLine("fb skor : " + fb);
                Console.WriteLine("gs skor : " + gs);
            }
            else
            {
                Console.WriteLine("Galatasaray is the winner");
                Console.WriteLine("fb skor : " + fb);
                Console.WriteLine("gs skor : " + gs);
            }
            

            Console.Read();
        }
    }
}
