class Reference
{
    private int _verse_count, _verse_start, _verse_end;
    private string _book, _chapter, _verses;
    public Reference(string filename)
    {
        string[] reference = filename.Split('_','.');
        _book = reference[0];
        _chapter = reference[1];
        _verses = reference[2];
        string verse_count_s = reference[2];
        int[] verse_ar = verse_count_s.Split('-').Select(int.Parse).ToArray();
        if (verse_ar.Length > 1)
        {
            _verse_start = verse_ar[0];
            _verse_end = verse_ar[1];
            _verse_count = _verse_end - _verse_start + 1;
        }else{
            _verse_start = _verse_end = verse_ar[0];
            _verse_count = 1;
        }
    }

    public string GetBook()
    {
        return _book;
    }

    public string GetChapter()
    {
        return _chapter;
    }

    public string GetVerses()
    {
        return _verses;
    }

    public int GetVerseCount()
    {        
        return _verse_count;
    }

    public int GetVerseStart()
    {
        return _verse_start;
    }

    public int GetVerseEnd()
    {
        return _verse_end;
    }
}