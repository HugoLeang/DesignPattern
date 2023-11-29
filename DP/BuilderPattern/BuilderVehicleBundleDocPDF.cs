namespace DesignPattern.BuilderPattern;

public class BuilderVehicleBundleDocPDF : IBuilderVehicleBundleDocument
{
    public DocumentBundle BuildVehicleCommercialDocument()
    {
        DocumentBundlePDF documentBundlePdf = new DocumentBundlePDF();
        documentBundlePdf.AddDocument("=====\n Commercial Document PDF \n ");
        return documentBundlePdf;
    }

    public DocumentBundle BuildVehicleID(DocumentBundle documentBundle)
    {
        documentBundle.AddDocument("ID Document PDF \n ===== \n ");
        return documentBundle;
    }
}