using System;

class Reference
{
    private string book, chapter, verse;

    public Reference(string Book, string Chapter, string Verse)
    {
        book = Book;
        chapter=Chapter;
        verse =Verse;
    }

    public string toString ()
    {
        return string.Format ("{0} {1}:{2}", book, chapter, verse);
    }


}