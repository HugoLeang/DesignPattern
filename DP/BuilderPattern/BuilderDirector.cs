namespace DesignPattern.BuilderPattern;

public class BuilderDirector
{
    private IBuilderVehicleBundleDocument m_Builder;
    private DocumentBundle m_Result;
    
    public enum Format
    {
        NONE,
        PDF,
        HTML,
    }
    
    public void BuildBundleDocument(Format format)
    {
        switch (format)
        {
            case Format.PDF:
                m_Builder = new BuilderVehicleBundleDocPDF();
                break;
            case Format.HTML:
                m_Builder = new BuilderVehicleBundleDocHTML();
                break;
        }
        m_Result = m_Builder.BuildVehicleCommercialDocument();
        m_Builder.BuildVehicleID(m_Result);
    }

    public DocumentBundle GetResult()
    {
        return m_Result;
    }
}