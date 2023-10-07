using System;

class JournalEntry
{
    public string Text;
    public DateTime Date;
    public string Prompt;

    public JournalEntry(string text, string prompt)
    {
        Text = text;
        Date = DateTime.Now;
        Prompt = prompt;
    }

    public string GetFormattedDate()
    {
        return Date.ToString("MM/dd/yyyy");
    }

    public override string ToString()
    {
        return $"Date: {GetFormattedDate()}\nPrompt: {Prompt}\nEntry: {Text}\n";
    }
}

class Journal
{
    private const int MaxEntries = 100;
    private JournalEntry[] entries = new JournalEntry[MaxEntries];
    private int entryCount = 0;

    public void AddEntry(string text)
    {
        if (entryCount < MaxEntries)
        {
            string[] prompts = {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?",
                "What are you most grateful for today?",
                "What was the most intersting conversation you had today",  
            };
            Random random = new Random();
            int promptIndex = random.Next(prompts.Length);
            string prompt = prompts[promptIndex];
            entries[entryCount++] = new JournalEntry(text, prompt);
        }
        else
        {
            Console.WriteLine("Journal is full. Cannot add more entries.");
        }
    }

    public void DisplayEntries()
    {
        Console.WriteLine("Journal Entries:");
        for (int i = 0; i < entryCount; i++)
        {
            Console.WriteLine(entries[i]);
        }
    }

    public void SaveJournalToFile(string filename)
    {
        Console.WriteLine("Saving the journal to a file is not implemented in this version.");
    }

    public void LoadJournalFromFile(string filename)
    {
        Console.WriteLine("Loading the journal from a file is not implemented in this version.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int run = 1;
        Console.WriteLine("Journal Program v0.0.1");
        do
        {
            int task = 0;
            Console.WriteLine("Choose one of the following:");
            Console.WriteLine("1: Write a New Entry");
            Console.WriteLine("2: Display Journal");
            Console.WriteLine("3: Save Journal to a File");
            Console.WriteLine("4: Load Journal from a File");
            Console.WriteLine("5: Quit");

            task = int.Parse(Console.ReadLine());
            switch (task)
            {
                case 1:
                    Console.WriteLine("Enter your journal entry:");
                    string entry = Console.ReadLine();
                    journal.AddEntry(entry);
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    Console.WriteLine("Enter the filename to save the journal:");
                    string saveFilename = Console.ReadLine();
                    journal.SaveJournalToFile(saveFilename);
                    Console.WriteLine($"Journal saved to {saveFilename}");
                    break;
                case 4:
                    Console.WriteLine("Enter the filename to load the journal:");
                    string loadFilename = Console.ReadLine();
                    journal.LoadJournalFromFile(loadFilename);
                    Console.WriteLine($"Journal loaded from {loadFilename}");
                    break;
                case 5:
                    run = 0;
                    break;
                default:
                    Console.WriteLine("Sorry, that is not a valid choice");
                    break;
            }

        } while (run != 0);
    }
}