namespace DesignPattern.BuilderPattern;

public class DocumentBundleHTML : DocumentBundle
{
    public DocumentBundleHTML() : base()
    {
        
    }
    public DocumentBundleHTML(DocumentBundle source) : base(source)
    {
    }

    public override DocumentBundle Clone()
    {
        return new DocumentBundleHTML(this);
    }
}