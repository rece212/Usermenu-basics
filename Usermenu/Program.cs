using System;

namespace Usermenu
{
    class Program
    {
      
        static void Main(string[] args)
        {

            bool bTrue = true;
            int value=-1;
            while (bTrue==true )
            {
                try
                {
                    Console.WriteLine("Please enter 1 or 2 only ");
                     value = Convert.ToInt32(Console.ReadLine());

                    if ( value ==1 || value==2)
                    {
                        bTrue = false;
                    }
                    else
                    {
                        Console.WriteLine("I said only enter 1 or 2");
                    }
                    
                }
                catch (Exception e)

                {
                    Console.WriteLine("Please enter in the correct value");
                }            
            }


            if(value == 1)
            {
                Console.WriteLine("Rent");
            }
            else if (value == 2)
            {
                Console.WriteLine("Buying");
            }
                

            


        }
    }
}
