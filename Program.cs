namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             To Print
            *
            **
            ***
            ****
            *****
            ******
            

             */

            for (int i = 0; i <= 6 ; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    
                 
                        Console.Write("*");
                   
                }
                Console.WriteLine();
            }

            for (int i = 6; i >= 1; i--)
            {
                for (int j = 1; j < i; j++)
                {

                    Console.Write("*");

                }
                Console.WriteLine();
                
            }

            for(int i = 0; i < 10; i++)
            {
                Console.Write("*");
            }
           
            }
    }
}