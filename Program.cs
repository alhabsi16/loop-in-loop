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

            for (int i = 1; i <= 6 ; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    
                 
                        Console.Write("*");
                   
                }
                Console.WriteLine();
            }

            /*
           To Print
          *****
          ****
          ***
          **
          *
        


           */

            for (int i = 5; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {

                    Console.Write("*");

                }
                Console.WriteLine();
                
            }

            /*
          To Print

         **********
        
          */

            for (int i = 0; i < 10; i++)
            {
                Console.Write("*");
            }
           
            }
    }
}