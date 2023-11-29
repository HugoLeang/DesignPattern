using BookProject.BooksManagement;
using BookProject.DatabaseService;
using DesignPattern.StatePattern;

public class BookManagementState : State 
{
    public override void Running(string command)
    {
        switch (command)
        {
            case "LIST":
                ListBooks();
                break;
            case "NOTIFY":
                NotifyRestitution();
                break;
        }
    }

    public override void Exit()
    {
        
    }

    public override void DisplayAvailableCommand()
    {
        Console.WriteLine("- LIST : List all the books \n" +
                          "- UPDATE : Update a book \n" +
                          "- NOTIFY : Notify for restitution \n ");
    }

    private void ListBooks()
    {
        List<Book> books =  DatabaseService.Instance.GetAllBooks();
        foreach (Book book  in books)
        {
            book.DisplayBookData();
        }
    }

    private void NotifyRestitution()
    {
        List<Book> books =  DatabaseService.Instance.GetAllBooks();
        books = books.Where(book => book.m_Borrowed).ToList();
        foreach (Book book  in books)
        {
            
            Product baseProduct = book;
            
            if ((book.NotifyMode & Product.NotificationMode.SMS)== Product.NotificationMode.SMS)
                baseProduct = new ProductSmsNotify(baseProduct);
            if ((book.NotifyMode & Product.NotificationMode.EMAIL) == Product.NotificationMode.EMAIL)
                baseProduct = new ProductEmailNotify(baseProduct);
                
            baseProduct.NotifyForRestitution();
        }
    }
}