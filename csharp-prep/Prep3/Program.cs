using System;

class Program
{
    static void Main(string[] args)
    {
        string play = "yes";
        while (play == "yes")
        {
            // Setup of Guess(es) and magic number
            Random magic_num_gen = new Random();
            int guess_try = 0;
            int guess_num = 0;
            int magic_num = magic_num_gen.Next(1,100);

            do
            {
                // This line is for deugging
                // Console.WriteLine($"What number am I thinking of?{magic_num}:");
                Console.WriteLine("What number am I thinking of? ");
                string guess = Console.ReadLine();
                guess_num = int.Parse(guess);
                guess_try++;
                
                // Higher or Lower? idk
                if (guess_num < magic_num)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess_num > magic_num)
                {
                    Console.WriteLine("Lower");
                }
            } while (guess_num != magic_num);
            
            // Gives score back to player
            Console.WriteLine($"You got it!\nNumber of Attempts: {guess_try}");
            // Ask player to play again
            Console.WriteLine("Do you want to play again? (yes/no)");
            play = Console.ReadLine();
        }

    }
}