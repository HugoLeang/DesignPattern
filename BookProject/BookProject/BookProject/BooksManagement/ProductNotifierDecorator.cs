namespace BookProject.BooksManagement;

public abstract class ProductNotifierDecorator : Product
{
    protected Product m_BaseProduct;

    public ProductNotifierDecorator(Product baseProduct)
    {
        m_BaseProduct = baseProduct;
    }

    public override void NotifyForRestitution()
    {
        m_BaseProduct.NotifyForRestitution();
    }

    public override void Restitute()
    {
        m_BaseProduct.Restitute();
    }
}