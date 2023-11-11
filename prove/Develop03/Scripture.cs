using System.Text.RegularExpressions;

class Scripture
{
    private string[] _verses;
    // private string _verse;
    public Scripture(string filename)
    {
        _verses = File.ReadAllLines(filename);
    }            

    public string GetVerse(int verse_num)
    {
        return _verses[verse_num];
    }

    public string WordErase(string wholeVerse)
    {
            Random rnd = new Random();
            string[] verseWords = wholeVerse.Split(' ');
            int wordNum = rnd.Next(0, verseWords.Length);
            string word = verseWords[wordNum];
            string replace = Regex.Replace(word, @"[a-zA-Z]", "_");
            verseWords[wordNum] = replace;
            string verse = string.Join(" ", verseWords);
        return verse;
    }
}