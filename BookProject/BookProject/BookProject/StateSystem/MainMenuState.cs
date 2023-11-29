namespace DesignPattern.StatePattern;
using MenuSystem;
using StatePattern;
public class MainMenuState : State
{
    public override void Enter()
    {
        Console.WriteLine("=== MAIN MENU ===");
        base.Enter();
    }

    public override void Running(string command)
    {
        switch (command)
        {
          case"BOOK":
              MenuSystem.Instance.SwitchState(new BookManagementState());
              break;
        }
    }

    public override void Exit()
    {
    }

    public override void DisplayAvailableCommand()
    {
        Console.WriteLine("- BOOK : Go to Book Management Menu");
    }
}