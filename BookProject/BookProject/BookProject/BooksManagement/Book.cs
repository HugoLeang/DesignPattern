namespace BookProject.BooksManagement;

public class Book : Product
{
    public string m_Name { get; protected set; }
    public string m_Author { get; protected set; }
    public  bool m_Borrowed { get; protected set; }
    public NotificationMode NotifyMode { get; set; }
    public Book(string name,string author,bool borrowed) : base()
    {
        m_Name = name;
        m_Author = author;
        m_Borrowed = borrowed;
    }
    
    public void DisplayBookData()
    {
        Console.WriteLine($"{m_Name} - {m_Author} [BORROWED: {m_Borrowed}]");
    }
    public override void NotifyForRestitution()
    {
        Console.WriteLine($"[Notify for Restitution - {m_Name} - {m_Author}]");
    }

    public override void Restitute()
    {
        m_Borrowed = false;
    }

    public override void Borrow()
    {
        m_Borrowed = true;
    }

    public override string GetName()
    {
        return m_Name;
    }

    public override string GetAuthor()
    {
        return m_Author;
    }
}