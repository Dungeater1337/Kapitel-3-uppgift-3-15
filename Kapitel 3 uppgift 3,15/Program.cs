using System; 

namespace uppgift3_15
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du hyra bilen?");
            int svar = int.Parse(Console.ReadLine());

            int avgift = 80; 
            
            int pris = svar * avgift;

            if (svar > 1 && svar < 11)
            {
                Console.WriteLine("det kommer att kosta dig "  +  pris); 
                  
            }

            else if (svar > 11)
            {
                Console.WriteLine("NEJJJJ NEJJJJJ"); 
            }





        }


    }
    
}