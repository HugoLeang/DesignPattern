using BookProject.DatabaseService;
using DesignPattern.MenuSystem;

class Program
{
    public static void Main(string[] args)
    {
        DatabaseService databaseService = DatabaseService.InitializeDatabaseService();
        MenuSystem menuSystem = MenuSystem.InitializeMenuSystem();
        menuSystem.RunningMainLoop();
    }
}