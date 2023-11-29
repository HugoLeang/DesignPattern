namespace BookProject.BooksManagement;

public class ProductEmailNotify : ProductNotifierDecorator
{
    public ProductEmailNotify(Product baseBook) : base(baseBook)
    {
    }
    public override void NotifyForRestitution()
    {
        base.NotifyForRestitution();
        Console.WriteLine($"[Notify by email] - Must restitute {m_BaseProduct.GetName()} - {m_BaseProduct.GetAuthor()}");
    }

    public override void Borrow()
    {
        m_BaseProduct.Borrow();
    }

    public override string GetName()
    {
        return m_BaseProduct.GetName();
    }

    public override string GetAuthor()
    {
        return m_BaseProduct.GetAuthor();
    }
}