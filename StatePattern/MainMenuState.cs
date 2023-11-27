namespace DesignPattern.StatePattern;

public class MainMenuState : IState
{
    public void Enter()
    {
        Console.WriteLine("=== MAIN MENU ===");
        DisplayAvailableCommand();
    }

    public void Running(string command)
    {
        throw new NotImplementedException();
    }

    public void Exit()
    {
        throw new NotImplementedException();
    }

    public void DisplayAvailableCommand()
    {
        throw new NotImplementedException();
    }
}