using System;

namespace numberGame
{
    class Program
    {
        static void Main(string[] args)
        {

            //Initializes random generator
            Random r = new Random();

            //winning number is chosen
            int winNum = r.Next(1, 100);

            //needed for loop
            bool win = false;

            do
            {
                Console.WriteLine("Enter a number between 1 an 100");
                string input = Console.ReadLine();

                int i = int.Parse(input);

                //too high
                if (i > winNum)
                {
                    Console.WriteLine("Too High! Go Lower!");
                }

                //too low
                else if( i < winNum)
                {
                    Console.WriteLine("Too Low! Go Higher!");
                }

                //correct guess
                else if(i == winNum)
                {
                    Console.WriteLine("That's it! You Win!");
                    win = true;
                }
                //formating line
                Console.WriteLine();
            } while (win == false);

            //needs input to finish program
            Console.WriteLine("Press and key to exit");
            Console.ReadKey(true);
        }
    }
}
