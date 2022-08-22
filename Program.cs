using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {

            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    Console.WriteLine("ocak ayındasınız");
                    break;
                case 2:
                    Console.WriteLine("subat ayındasınız");
                    break;
                case 3:
                    Console.WriteLine("mart ayındasınız");
                    break;
                case 4:
                    Console.WriteLine("nisan ayındasınız");
                    break;
                default:
                    Console.WriteLine("yanlış veri girdiniz");
                    break;
            }


            switch(month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("kıs ayındasınız");
                    break;
                case 4:
                case 5:
                case 3:
                    Console.WriteLine("ilkbahar ayındasınız");
                    break;
                case 7:
                case 8:
                case 6:
                    Console.WriteLine("yaz ayındasınız");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("sonbahar ayındasınız");
                    break;

                default:
                    break;
            }











            Console.ReadLine();
        }
    }
}
