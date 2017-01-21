using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_SoftwareArch_Console
{
    class Program
    {

        // echos the user's name and prints a randomly chosen int:
        static void Main(string[] args)
        {
            Console.Write("Guess an int, M, in range 0..10: M = ");
            string sM = Console.ReadLine();
            int M = Int32.Parse(sM);
            if (M < 0|| M > 10)
                Console.WriteLine(" the number selected does not work pick again");
            else
            {
                //create random number
                Random r = new Random();
                int min = 0;
                int max = M;
                int N = r.Next(min, max + 1);
                Console.Write("I guess int, N, in range 0..10-M: N = " + N);

                Console.Write("now you type an int, P, such that M + N + P = 10: P = ");
                string sP = Console.ReadLine();
                int P = Int32.Parse(sP);

                if(M + N + P == 10)
                    Console.Write("You win!");
                else
                    Console.Write("You lose!");

            }
            // retain command window till user presses Enter
            Console.ReadLine();
        }
    }
}
