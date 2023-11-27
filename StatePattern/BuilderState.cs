using DesignPattern.BuilderPattern;

namespace DesignPattern.StatePattern;

public class BuilderState : IState
{
    public void Enter()
    {
        
    }

    public void Running(string command)
    {
        BuilderDirector director = new BuilderDirector();
        switch (command)
        {
            case "HTML":
                director.BuildBundleDocument(BuilderDirector.Format.HTML);
                director.GetResult().PrintDocuement();
                break;
            case "PDF":
                director.BuildBundleDocument(BuilderDirector.Format.PDF);
                director.GetResult().PrintDocuement();
                break;
        }
        
    }

    public void Exit()
    {
        
    }

    public void DisplayAvailableCommand()
    {
        
    }
}