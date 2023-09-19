using System;

class Program
{
    static void Main(string[] args)
    {
        Random magic_num_gen = new Random();
        int guess_try = 0;
        int guess_num = 0;
        int magic_num = magic_num_gen.Next(1,100);

        do
        {
            Console.WriteLine($"What number am I thinking of?{magic_num}:");
            string guess = Console.ReadLine();
            guess_try = guess_try++;
            guess_num = int.Parse(guess);
        } while (guess_num != magic_num);

        Console.WriteLine($"You got it!\nNumber of Attempts: {guess_try}");

    }
}