class Scripture
{
    private int verse_count;
    private string verses;
    public Scripture(string filename);
    {
        string[] reference = filename.Split('_','.');
        verses = reference[2];
    }
    }
}