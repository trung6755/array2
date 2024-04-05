using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, sum = 0;
            int[,] ints = new int[3, 3];

            Console.Write("Nhap phan tu ma tran: ");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("Phan tu - [{0}],[{1}]:", i, j);
                    ints[i, j] = int.Parse(Console.ReadLine());
                    if (i == j)
                    {
                        sum = sum + ints[i, j];
                    }
                }
            }

            Console.Write("In ma tran:\n");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                    Console.Write("{0} ", ints[i, j]);
                Console.Write("\n");
            }

            Console.Write("Tong cac phan tu tren duong cheo chinh la: {0}\n", sum);

            Console.ReadKey();



        }
    }
}
