using System;

namespace Console_urok
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            /*
             Тема  switch  
                    if else
             
             while (true)
            {
                Console.Clear();
                double fff, rrr;
                string aaa;
                try
                {
                    
                    Console.WriteLine("число 1");
                    fff = double.Parse(Console.ReadLine());
                                    
                    Console.WriteLine("число 2");
                    rrr = double.Parse(Console.ReadLine());
                }
                catch (Exception )
                {
                    Console.WriteLine("Ошибка");
                    Console.ReadLine();
                   continue;
                }
                
    
                Console.WriteLine("'-' '+' '*' '/' ");
                aaa = Console.ReadLine();
                if (aaa=="-")
                {
                    Console.WriteLine(fff-rrr); 
                } 
                else if (aaa=="+")
                {
                    Console.WriteLine(fff+rrr);
                }
                else if (aaa=="*")
                {
                    Console.WriteLine(fff*rrr);
                }
                else if (aaa=="/")
                {
                    if (rrr==0)
                    {
                        Console.WriteLine(0);
                    }
                    else
                    {
                         Console.WriteLine(fff/rrr);
                    }
                   
                }
                else
                {
                    Console.WriteLine("Ошибка");
                }
                
                Console.ReadLine();

            }
            */



            
            
            
            

            
            
             /*
             Тема While
                         int dd = 0;
                         int ddw = int.Parse(Console.ReadLine());
                         
                         string count=(Console.ReadLine()) ;
                         do
                         {
                             dd++;
                             Console.WriteLine(dd + ": " + count + " Альбина");
                         } while (dd < ddw);

             */

             
             
             
             
             

                /*
                while (true)
                {
                     Console.Clear();
                    uint dddNumbercount = 0;  /*не чётные#1#
                    uint aaaNumbercount = 0;  /* чётные#1#
                    
                    int dddNumberSum = 0; 
                    int aaaNumberSum = 0;  
                    
                    

                    try
                    {
                         Console.WriteLine("ведите первое число");
                        int ss = int.Parse(Console.ReadLine());
                        Console.WriteLine("ведите второе число");
                        int limit = int.Parse(Console.ReadLine());
                        
                        while (ss <= limit)
                        {
                           
                            if (ss % 2 == 0)
                            {
                                aaaNumbercount++;
                                aaaNumberSum = aaaNumberSum + ss;
                            }
                            else
                            {
                                dddNumbercount++;
                                dddNumberSum = dddNumberSum + ss;
                            }
                        
                            ss++;
                            
                        }
                        
                    }
                    catch (Exception )
                    {
                        Console.WriteLine("stop");
                        Console.ReadLine();
                        continue;
                    }
                   
                   
                                    
                           
                    Console.WriteLine(" не чётные  "  + dddNumbercount);
                    Console.WriteLine("чётные  "  + aaaNumbercount);
                    Console.WriteLine("сумма не чётные  "  + dddNumberSum);
                    Console.WriteLine("сумма  чётные "  + aaaNumberSum);
                    Console.ReadLine();         
                                    
                }
                */



                /*
                while (true)
                {
                    Console.Clear();
                     int limit = int.Parse(Console.ReadLine());
                    for (int i = 0; i < limit; i++)
                    {
                       Console.WriteLine(i); 
                       
                    }

                    Console.ReadLine();

                }
                */
                
                
                

                for (; ;)
                {
                    Console.WriteLine("Альбина");
                    System.Threading.Thread.Sleep(700);
                    
                }

                



        }
    }   
}