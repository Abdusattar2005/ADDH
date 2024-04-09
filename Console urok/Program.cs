using System;

namespace Console_urok
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            /*
            int a;
            a = int.Parse(Console.ReadLine());
            int temp = a - 2;
            bool result = temp >= 0;
            if (result) 
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }*/

            /*int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
               
                case 2:
                    Console.WriteLine("ffffff 1 или 2 ");
                    break;
                default:                    Console.WriteLine("noo");
                    break;
            }*/

            double fff, dddd;
            string aaa;
            Console.WriteLine("Ведите чисо 1");
            fff = double.Parse(Console.ReadLine());
            

            Console.WriteLine("Ведите число 2");
            dddd = double.Parse(Console.ReadLine());
         
            
            Console.WriteLine("Ведите оперфцию: '+' '-' '*' '/'");
            aaa = Console.ReadLine();

            switch (aaa)
            {
                case "+" :
                    Console.WriteLine(fff+dddd);
                    break;
                case "-":
                    Console.WriteLine(fff-dddd);
                    break; 
                case "*":
                    Console.WriteLine(fff*dddd);
                    break; 
                case "/":
                    Console.WriteLine(fff/dddd);
                    if (fff==0)
                    {
                        Console.WriteLine(0);
                    }
                    else
                    {
                        Console.WriteLine(fff/dddd);
                    }
                    break;
                   
                default:
                    Console.WriteLine("нет токого");
                    break;
                    
            }

            Console.ReadLine();

        }
    }   
}