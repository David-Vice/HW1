using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {

            //task1
            /*
            ConsoleKeyInfo mykey;
            int spaces = 0;
            while(true)
            {
                mykey = Console.ReadKey(true);
                if (mykey.KeyChar == '.')
                {
                    Console.WriteLine($"\nNumber of spaces: {spaces}");
                    break;
                }
                else
                {
                    Console.Write(mykey.KeyChar);
                    if (mykey.KeyChar == ' ') spaces++;
                }
            }
            */

            //task2
            /*
            string ticketNum = Console.ReadLine();
            int from0to2 = 0;
            int from3to5 = 0;
            for (int i = 0; i <= 2; i++) from0to2 += Int32.Parse(ticketNum[i].ToString());
            for (int i = 3; i <= 5; i++) from3to5 += Int32.Parse(ticketNum[i].ToString());
            if (from0to2 == from3to5) Console.WriteLine("Happy Ticket");
            else Console.WriteLine("Sad Ticket");
            */

            //task3
            /*
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                char tmp = key.KeyChar;
                if (key.KeyChar >= 60 && key.KeyChar <= 90)
                {
                    tmp = (char)((int)tmp + 32);
                }
                else if (key.KeyChar >= 97 && key.KeyChar <= 122)
                {
                    tmp = (char)((int)tmp - 32);
                }
                Console.Write(tmp);
            } while (key.Key != ConsoleKey.Enter);
            */

            //task4
            /*
            Console.Write("Enter A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Enter B: ");
            int B = int.Parse(Console.ReadLine());

            for(int i = A; i <= B; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            */

            //task 5
            /*
            string number = Console.ReadLine();
            for (int i = number.Length - 1; i >= 0; i--) Console.Write(number[i]);
            Console.WriteLine();
            */
        }
    }
}
