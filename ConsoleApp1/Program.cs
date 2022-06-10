using System;

namespace Fibonacci
{
   public  class Program
    {
        static void Main(string[] args)
        {
           
        }

        public static int serieFibonacci(int numero)
        {
            int num1 = 0;
            int num2 = 1;

            if (numero == 0)
            {
                return 0;
            }else if (numero == 1 || numero==2)
            {
                return 1;
            }
            else
            {
                for (int i = 0; i < numero; i++)
                {
                    int temp = num1;
                    num1 = num2;
                    num2 = temp + num2;
                }
            }

            
            return num1;
        }
      
    }
}
