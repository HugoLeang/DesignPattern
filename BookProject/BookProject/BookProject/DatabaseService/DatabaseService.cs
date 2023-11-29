using System.Globalization;
using System.Reflection;
using BookProject.BooksManagement;
using CsvHelper;

namespace BookProject.DatabaseService;
public class DatabaseService
{
    public static DatabaseService Instance { get; private set; }
    private static string m_ProjectDirectory;
    public static DatabaseService InitializeDatabaseService()
    {
        if (Instance == null)
        {
            Instance = new DatabaseService();
            string currentDir = Environment.CurrentDirectory;
            m_ProjectDirectory = Directory.GetParent(currentDir).Parent.Parent.FullName;
        }

        return Instance;
    }

    public List<Book> GetAllBooks()
    {
        List<BookModel> bookModels = new List<BookModel>();
        
        StreamReader reader = new StreamReader($"{m_ProjectDirectory}/data.csv");
        CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture);

        bookModels = csv.GetRecords<BookModel>().ToList();
        return ParseBookModels(bookModels);
    }

    public void UpdateBook(Book bookToUpdate)
    {
        
    }

    public void WriteBook(Book bookToWrite)
    {
        
    }

    private List<Book> ParseBookModels(List<BookModel> bookModels)
    {
        List<Book> books = new List<Book>();
        foreach (BookModel bookModel in bookModels)
        {
            bool borrowed = bookModel.Borrowed.Equals("TRUE");
            Book bookParsed = new Book(bookModel.Name,bookModel.Author,borrowed);
            
            if(bookModel.SMSNotify.Equals("TRUE"))
                bookParsed.NotifyMode  |= Product.NotificationMode.SMS;
            if (bookModel.EmailNotify.Equals("TRUE"))
                bookParsed.NotifyMode |= Product.NotificationMode.EMAIL;
            
            books.Add(bookParsed);
        }

        return books;
    }
    
}