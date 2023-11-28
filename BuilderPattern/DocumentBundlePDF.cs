namespace DesignPattern.BuilderPattern;

public class DocumentBundlePDF : DocumentBundle
{
    public DocumentBundlePDF() : base()
    {
    }
    public DocumentBundlePDF(DocumentBundle source) : base(source)
    {
    }

    public override DocumentBundle Clone()
    {
        return new DocumentBundlePDF(this);
    }
}