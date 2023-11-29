namespace DesignPattern.StatePattern;

public interface IState
{
  void Enter();
  void Running(string command);
  void Exit();
  void DisplayAvailableCommand();
}