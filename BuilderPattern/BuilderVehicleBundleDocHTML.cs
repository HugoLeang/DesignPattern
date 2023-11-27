    namespace DesignPattern.BuilderPattern;

public class BuilderVehicleBundleDocHTML : IBuilderVehicleBundleDocument
{
    public DocumentBundle BuildVehicleCommercialDocument()
    {
        DocumentBundleHTML documentBundleHtml = new DocumentBundleHTML();
        documentBundleHtml.AddDocument("Commercial Document HTML \n");
        return documentBundleHtml;
    }

    public DocumentBundle BuildVehicleID(DocumentBundle documentBundle)
    {
        documentBundle.AddDocument("ID Document HTML \n");
        return documentBundle;
    }
}