using System;
using System.IO;
class Program
{
    static void Main()
    {
        string ScriptureFile = "scripture_library.txt";
        string[] lines = File.ReadAllLines(ScriptureFile);
        string[] ScriptureLines = lines.Split('\n');
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

    }
}