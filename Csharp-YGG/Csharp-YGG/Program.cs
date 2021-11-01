using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_YGG
{
    class Program
    {
        static void Main(string[] args)
        {


            WhileTest(0);
            //C04();
            //C03();
            //C02();
            //C01();
            //Console.ReadLine();
            Console.ReadLine();
        }

        private static void WhileTest(int val)
        {

            while (val != 100)
            {
                Console.WriteLine(val);
                val += 10;
            }
        }

        private static void C04()
        {
            int[] arr = new int[10] {2, 4, 6, 8, 10, 12, 14, 16, 18, 20};

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        private static void C03()
        {
            int val = 10;
            if (val == 10)
            {
                Console.WriteLine("Val 10");
            }
            else if (val == 20)
            {
                Console.WriteLine("Val 20");
            }
            else
            {
                Console.WriteLine("none");
            }

            switch (val)
            {
                case 10:
                    Console.WriteLine("S C Val 10");
                    break;
                case 20:
                    Console.WriteLine("S C Val 20");
                    break;
                default:
                    Console.WriteLine("S C none");
                    break;
            }
        }

        private static void C02()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("YGG");
            builder.Append("C# kurs");

            Console.WriteLine(builder.ToString());

            Console.WriteLine("YGG" + " - " + "C# kurs");
        }

        static void C01()
        {
            int a = 5;
            long b = long.MaxValue;

            string conv = "200";

            //int strToInt = Convert.ToInt32(conv);
            int strToInt;

            bool isConvertable = int.TryParse(conv, out strToInt);

            Console.WriteLine(isConvertable);
            Console.WriteLine(strToInt);
        }
    }
}
