using DesignPattern.CompositePattern;
using DesignPattern.Interfaces;

namespace DesignPattern.StatePattern;

public class CompanyTreeState : IState
{
    private CompanyTree m_Tree;
    public void Enter()
    {
        m_Tree = BuildTree();
        DisplayAvailableCommand();
    }

    public void Running(string command)
    {
        switch (command)
        {
            
            case "COUNT":
                Console.WriteLine(m_Tree.Count());
                break;
            case "DISPLAY":
                m_Tree.Execute();
                break;
        }
    }

    public void Exit()
    {
        
    }

    public void DisplayAvailableCommand()
    {
        Console.WriteLine("- COUNT : Display number of company in the tree \n" +
                          "- DISPLAY : Display names of company Subsidiary ");
    }

    private CompanyTree BuildTree()
    {
        CompanyTree mainCompanyTree = new CompanyTree("Main Company");
        List<CompanyTree> secondLevelCampanies = new List<CompanyTree>();
        
        secondLevelCampanies.Add(new CompanyTree("Company A"));
        secondLevelCampanies.Add(new CompanyTree("Company B"));

        mainCompanyTree.AddChildren(new CompanyLeaf("Company Leaf C"));
        
        secondLevelCampanies[0].AddChildren(new CompanyLeaf("Leaf Company A - 1"));
        secondLevelCampanies[0].AddChildren(new CompanyLeaf("Leaf Company A - 2 "));
        
        secondLevelCampanies[1].AddChildren(new CompanyLeaf("Leaf Company B - 1"));
        secondLevelCampanies[1].AddChildren(new CompanyLeaf("Leaf Company B - 2 "));
        
        mainCompanyTree.AddChildren(secondLevelCampanies );
        
        return mainCompanyTree;
    }
}