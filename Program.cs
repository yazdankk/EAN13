using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace EAN13
{
    internal class Program
    {
        static void Main()
        {
            int[] barcode = new int[12];
            int[] numBarcode = new int[12];
            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine("Enter barcode digits");
                barcode[1] = int.Parse(Console.ReadLine());
                if (numBarcode[i] < 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Number is bigger than 9");
                }
            }
        }
    }
}