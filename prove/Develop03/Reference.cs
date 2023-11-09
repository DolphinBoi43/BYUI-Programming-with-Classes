class Reference
{
    private int verse_count, verse_start, verse_end;
    private string book, chapter, verses;
    public Reference(string filename)
    {
        string[] reference = filename.Split('_','.');
        book = reference[0];
        chapter = reference[1];
        verses = reference[2];
        string verse_count_s = reference[2];
        int[] verse_ar = verse_count_s.Split('-').Select(int.Parse).ToArray();
        if (verse_ar.Length > 1)
        {
            verse_start = verse_ar[0];
            verse_end = verse_ar[1];
            verse_count = verse_end - verse_start + 1;
        }else{
            verse_start = verse_end = verse_ar[0];
            verse_count = 1;
        }
    }

    public string GetBook()
    {
        return book;
    }

    public string GetChapter()
    {
        return chapter;
    }

    public string GetVerses()
    {
        return verses;
    }

    public int GetVerseCount()
    {        
        return verse_count;
    }
}