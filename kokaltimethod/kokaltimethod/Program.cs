using System;

namespace kokaltimethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 42;
            num = Scuare( num);

            Console.WriteLine(num);
        }
        static int Scuare(  int number)
        {
            int i=0 ;

            while (i*i<=number)
            {
                i++;
               
            }
                
            
            if (i*i==0)
            {
                Console.WriteLine(i);
            }

            return i;
            
           
        }
    }
}
