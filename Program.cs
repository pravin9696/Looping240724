using System;

namespace Looping240724
{
    
    internal class Program
    {
        
       
        static void Main(string[] args)
        {
            #region switch example
            //int x = 2001;

            //switch (x)
            //{

            //    case 200:
            //        Console.WriteLine("200 printed");  break;
            //    case 100:
            //        Console.WriteLine("100 printed");
            //        break;
            //    default:
            //        Console.WriteLine("default printed");
            //        break;
            //}
            #endregion
            #region even odd program using switch
            // WAP to check no is even or odd using switch

            //int no;

            //Console.WriteLine("Enter number");
            //no = int.Parse(Console.ReadLine());
            //switch (no % 2)
            //{
            //    case 0:
            //        Console.WriteLine("no is even");
            //        break;
            //    case 1:
            //        Console.WriteLine("no is odd");
            //        break;
            //}
            #endregion

            #region working of while loop
            //int i = 7;
            //while (i < 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            #endregion

            #region working of do while loop
            //int i = 1;

            //do
            //{
            //    Console.WriteLine(i);//7
            //    i++;//8
            //} while (i < 5);//false
            #endregion

            #region working of for loop
            //int i;
            //for (i = 1; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("-----------");
            //for (i = 4; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region loop Assignment 1
            //Write a C# program to print all natural numbers from 1 to n. - using while loop

            int n;
            Console.WriteLine("Enter upper limit to print all natural numbers:");
            n=int.Parse(Console.ReadLine());
            int i = 1;
            while(i<=n)
            {
                Console.Write(i+"\t");
                i++;
            }
            #endregion
            Console.ReadKey();
        }
    }
}
