using System;
using System.IO;

class JournalEntry
{
    public string Text;
    public DateTime Date;
    public string Prompt;
    public string Location;

    public JournalEntry(string text, string prompt, string location)
    {
        Text = text;
        Date = DateTime.Now;
        Prompt = prompt;
        Location = location;
    }

    public string GetFormattedDate()
    {
        return Date.ToString("MM/dd/yyyy");
    }

    public override string ToString()
    {
        return $"Date: {GetFormattedDate()}\nPrompt: {Prompt}\nLocation: {Location}\nEntry: {Text}\n";
    }
}

class Journal
{
    private const int MaxEntries = 100;
    private JournalEntry[] entries = new JournalEntry[MaxEntries];
    private int entryCount = 0;

    private Random random = new Random();

    public string GetRandomPrompt()
    {
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What are you most grateful for today?",
            "What was the most interesting conversation you had today",
        };
        int promptIndex = random.Next(prompts.Length);
        return prompts[promptIndex];
    }

    public void AddEntry()
    {
        if (entryCount < MaxEntries)
        {
            string prompt = GetRandomPrompt();
            Console.WriteLine($"{prompt}\nEnter Entry:");
            string text = Console.ReadLine();
            Console.WriteLine("Enter the location:");
            string location = Console.ReadLine();

            entries[entryCount++] = new JournalEntry(text, prompt, location);
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
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                for (int i = 0; i < entryCount; i++)
                {
                    writer.WriteLine($"Date: {entries[i].GetFormattedDate()}");
                    writer.WriteLine($"Prompt: {entries[i].Prompt}");
                    writer.WriteLine($"Location: {entries[i].Location}");
                    writer.WriteLine($"Entry: {entries[i].Text}\n");
                }
            }
            Console.WriteLine($"Journal saved to {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    public void LoadJournalFromFile(string filename)
    {
        try
        {
            if (File.Exists(filename)) // Check if the file exists
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    while (!reader.EndOfStream)
                    {
                        string dateLine = reader.ReadLine();
                        string promptLine = reader.ReadLine();
                        string locationLine = reader.ReadLine();
                        string entryLine = reader.ReadLine();

                        if (dateLine != null && dateLine.StartsWith("Date: ") &&
                            promptLine != null && promptLine.StartsWith("Prompt: ") &&
                            locationLine != null && locationLine.StartsWith("Location: ") &&
                            entryLine != null && entryLine.StartsWith("Entry: "))
                        {
                            string date = dateLine.Substring(6); // Remove "Date: "
                            string prompt = promptLine.Substring(8); // Remove "Prompt: "
                            string location = locationLine.Substring(10); // Remove "Location: "
                            string entry = entryLine.Substring(7); // Remove "Entry: "

                            DateTime parsedDate = DateTime.Parse(date);
                            entries[entryCount++] = new JournalEntry(entry, prompt, location)
                            {
                                Date = parsedDate
                            };
                        }
                        else
                        {
                            Console.WriteLine("Invalid format in the journal file. Skipping entry.");
                        }
                    }
                }
                Console.WriteLine($"Journal loaded from {filename}");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
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
                    journal.AddEntry();
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    Console.WriteLine("Enter the filename to save the journal:");
                    string saveFilename = Console.ReadLine();
                    journal.SaveJournalToFile(saveFilename);
                    break;
                case 4:
                    Console.WriteLine("Enter the filename to load the journal:");
                    string loadFilename = Console.ReadLine();
                    journal.LoadJournalFromFile(loadFilename);
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
