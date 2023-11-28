namespace DesignPattern.BuilderPattern;

public abstract class DocumentBundle
{
    public string m_DocumentContent { get; protected set; }

    public DocumentBundle()
    {
        m_DocumentContent = "";
    }

    public DocumentBundle(DocumentBundle source)
    {
        m_DocumentContent = source.m_DocumentContent;
    }

    public abstract DocumentBundle Clone();

    public void AddDocument(string documementToAdd)
    {
        m_DocumentContent += documementToAdd;
    }

    public void PrintDocuement()
    {
        Console.WriteLine(m_DocumentContent);
    }
    
}