using DesignPattern.Interfaces;

namespace DesignPattern.CompositePattern;

public class CompanyTree : ISubsidiary
{
    public List<ISubsidiary> m_Children { get; private set; }
    public string m_CompanyName { get; private set; }
    public CompanyTree(string companyName ="Unknown company")
    {
        m_Children = new List<ISubsidiary>();
        m_CompanyName = companyName;
    }
    
    public void AddChildren(ISubsidiary child)
    {
        m_Children.Add(child);
    }

    public void AddChildren(List<ISubsidiary> children)
    {
        m_Children.AddRange(children);
    }
    public void AddChildren(List<CompanyTree> children)
    {
        m_Children.AddRange(children);
    }

    public void RemoveChildren(ISubsidiary childToRemove)
    {
        m_Children.Remove(childToRemove);
    }
    
    public void Execute()
    {
        Console.WriteLine($" Tree => {m_CompanyName}");
        foreach (ISubsidiary subsidiary in m_Children)
        {
            subsidiary.Execute();
        }
    }

    public int Count()
    {
        int count = 1;
        foreach (ISubsidiary child in m_Children)
        {
            count += child.Count();
        }
        return count;
    }
}