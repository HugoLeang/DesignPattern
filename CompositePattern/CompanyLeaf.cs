using DesignPattern.Interfaces;

namespace DesignPattern.CompositePattern;

public class CompanyLeaf : ISubsidiary
{
    public string m_CompanyLeafName { get; private set; }

    public CompanyLeaf(string companyName = "Leaf company")
    {
        m_CompanyLeafName = companyName;
    }
    public void Execute()
    {
        Console.WriteLine($"Company Leaf - {m_CompanyLeafName}");
    }

    public int Count()
    {
        return 1;
    }
}