namespace DesignPattern.BuilderPattern;

public interface IBuilderVehicleBundleDocument
{ 
    DocumentBundle BuildVehicleCommercialDocument();
    DocumentBundle BuildVehicleID(DocumentBundle documentBundle);
}