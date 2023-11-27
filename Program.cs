using DesignPattern.AbstractFactory;
using DesignPattern.MenuSystem;

public static class Program
{
    private static void Main(string[] args)
    {
        
        MenuSystem.InitializeMenuSystem();
        MenuSystem.Instance.RunningMainLoop();
        
        
      

    }
}
