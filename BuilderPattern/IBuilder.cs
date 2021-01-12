namespace BuilderPattern
{
    /* The build context here is a vehicle builder, a vehicle is composed of a Body, wheels and headlights. The builder itself is not concerned with what the body, wheels and headlights are comprised of. All it cares is to put these things together, i.e., how they go along into building the product 
    Continue to the Director Class */
    public interface IBuilder
    {
        void StartUpOperations();
        void BuildBody();
        void InsertWheels();
        void AddHeadlights();
        void EndOperations();
        ProductSpecification GetVehicle();
    }
}