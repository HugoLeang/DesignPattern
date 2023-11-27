namespace DesignPattern.BuilderPattern;

public class DocumentBundle
{
    private string m_DocumentContent;
    public void AddDocument(string documementToAdd)
    {
        m_DocumentContent += documementToAdd;
    }

    public void PrintDocuement()
    {
        Console.WriteLine(m_DocumentContent);
    }
}