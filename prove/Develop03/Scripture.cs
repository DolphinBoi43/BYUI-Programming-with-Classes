using System.Text.RegularExpressions;

class Scripture
{
    private string[] _verses;
    private string _verse;
    public Scripture(string filename)
    {
        _verses = File.ReadAllLines(filename);
    }            

    public string GetVerse(int verse_num)
    {
        return _verses[verse_num];
    }

    public string WordErase(string whole_verse)
    {
        Random rnd = new Random();
        string[] verse_words = whole_verse.Split(' ');
        int word_num = rnd.Next(0,verse_words.Length);
        string word = verse_words[word_num];
        string replace = Regex.Replace(word, @"(a-Z)","_$1");
        verse_words[word_num] = replace;
        _verse = string.Join(" ", verse_words);
        return _verse;
    }
}