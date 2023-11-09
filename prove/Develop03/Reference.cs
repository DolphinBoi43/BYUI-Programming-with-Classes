class Reference
{
    private string book;
    private string chapter;
    private string verses;
    public Reference(string filename)
    {
        string[] reference = filename.Split('_','.');
        book = reference[0];
        chapter = reference[1];
        verses = reference[2];
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
}