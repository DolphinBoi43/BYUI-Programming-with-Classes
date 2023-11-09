class Scripture
{
    private string verse_count_s;
    private int verse_count, verse_start, verse_end;
    private string[] verses;
    public Scripture(string filename)
    {
        string[] reference = filename.Split('_','.');
        verse_count_s = reference[2];
        verses = File.ReadAllLines(filename);
    }            

    public string GetScriptures(int verse_num)
    {
        return verses[verse_num];
    }

    public int GetVerseCount()
    {
        int[] verse_count_ar = verse_count_s.Split('-').Select(int.Parse).ToArray();
        if (verse_count_ar.Length > 1)
        {
            verse_count = verse_count_ar[1] - verse_count_ar[0] + 1;
        }else{
            verse_count = 1;
        }
        
        return verse_count;
    }


}