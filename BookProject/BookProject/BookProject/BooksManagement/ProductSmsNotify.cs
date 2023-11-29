namespace BookProject.BooksManagement;

public class ProductSmsNotify :  ProductNotifierDecorator
{
    public ProductSmsNotify(Product baseProduct) : base(baseProduct)
    {
    }

    public override void NotifyForRestitution()
    {
        base.NotifyForRestitution();
        Console.WriteLine($"[Notify by SMS] - Must restitute {m_BaseProduct.GetName()} - {m_BaseProduct.GetAuthor()}");
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