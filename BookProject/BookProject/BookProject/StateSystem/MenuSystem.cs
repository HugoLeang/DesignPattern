using DesignPattern.StatePattern;

namespace DesignPattern.MenuSystem;

public class MenuSystem
{
    public static MenuSystem Instance { get; private set; }
    
    private bool m_Running = true;
    private State m_CurrentState;
    private string m_UserInput;

    public static MenuSystem InitializeMenuSystem()
    {
        if (Instance == null)
            Instance = new MenuSystem();
        
        return Instance;
    }
    
    private MenuSystem()
    {
        SwitchState(new MainMenuState());
    }
    
    public void RunningMainLoop()
    {
        while (m_Running)
        {
           
            DisplayNavigationCommand();
            HandleUserInput("Enter a command: ");
            switch (m_UserInput)
            {
                case "HELP":
                    m_CurrentState.DisplayAvailableCommand();
                    break;
                case "MENU":
                    SwitchState(new MainMenuState());
                    break;
                case "EXIT":
                    StopLoop();
                    break;
                default:
                    m_CurrentState.Running(m_UserInput);
                    break;
            }
        }
    }

    public void StopLoop()
    {
        m_Running = false;
    }

    public void SwitchState(State newState)
    {
        m_CurrentState?.Exit();
        
        m_CurrentState = newState;
        m_CurrentState.Enter();
    }
    public void ReturnToMainMenu()
    {
        SwitchState(new MainMenuState());
    }
    private void HandleUserInput(string prompt)
    {
        Console.WriteLine(prompt);
        m_UserInput = Console.ReadLine().ToUpper();
    }

    private void DisplayNavigationCommand()
    {
        Console.WriteLine("NAVIGATION COMMAND: (HELP / MENU)");
    }
}