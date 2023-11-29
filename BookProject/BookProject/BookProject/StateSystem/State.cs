namespace DesignPattern.StatePattern;

public abstract class State
{
  public virtual void Enter()
  {
   DisplayAvailableCommand(); 
  }
  public abstract void Running(string command);
  public abstract void Exit();
  public abstract void DisplayAvailableCommand();
}