namespace BookProject.BooksManagement;

public abstract class Product
{
    
    public virtual void NotifyForRestitution(){}

    public abstract void Restitute();
    public abstract void Borrow();
    public abstract string GetName();
    public abstract string GetAuthor();
    [Flags]
    public enum NotificationMode
    {
        NONE = 0,
        SMS = 1,
        EMAIL = 2,
    }
}