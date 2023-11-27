using DesignPattern.StatePattern;

namespace DesignPattern.MenuSystem;

public class MenuSystem
{
    public static MenuSystem Instance = null;
    
    private bool m_Running = true;
    private IState m_CurrentState;
    private string m_UserInput;

    public static void InitializeMenuSystem()
    {
        if (Instance == null)
            Instance = new MenuSystem();
    }
    
    private MenuSystem()
    {
        SwitchState(new VehicleCatalogState());
    }
    
    public void RunningMainLoop()
    {
        while (m_Running)
        {
            HandleUserInput("Enter a command: ");
            if(m_UserInput.Equals("HELP"))
                m_CurrentState.DisplayAvailableCommand();
            else
                m_CurrentState.Running(m_UserInput);    
        }
    }

    public void StopLoop()
    {
        m_Running = false;
    }

    public void SwitchState(IState newState)
    {
        m_CurrentState?.Exit();
        
        m_CurrentState = newState;
        m_CurrentState.Enter();
    }

    public void ReturnToMainMenu()
    {
        
    }
    private void HandleUserInput(string prompt)
    {
        Console.WriteLine(prompt);
        m_UserInput = Console.ReadLine().ToUpper();
    }
}