using System.Collections;
using System.Collections.Generic;

public class Book
{
    private string title;
    private string author;
    private string date;
    private string language;
    private Dictionary<string, string> links;

    public Book(string title, string author, string date, string language, Dictionary<string, string> links)
    {
        this.title = title;
        this.author = author;
        this.date = date;
        this.language = language;
        this.links = links;
    }

    public string GetTitle()
    {
        return title;
    }
    
    public string GetAuthor()
    {
        return author;
    }

    public string GetDate()
    {
        return date;
    }

    public string GetLanguage()
    {
        return language;
    }

    public Dictionary<string, string> GetLinks()
    {
        return links;
    }
}
