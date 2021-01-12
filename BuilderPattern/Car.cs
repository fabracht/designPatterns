namespace BuilderPattern
{
    public class Car : IBuilder
    {
        private string brandName;
        private ProductSpecification product;
        public Car(string brand)
        {
            product = new ProductSpecification();
            this.brandName = brand;
        }
        public void StartUpOperations()
        {   // Starting with brandname
            product.Add("-----------");
            product.Add($"Car model name :{this.brandName}");
        }
        public void BuildBody()
        {
            product.Add("This is a body of a Car");
        }
        public void InsertWheels()
        {
            product.Add("4 wheels are added");
        }
        public void AddHeadlights()
        {
            product.Add("2 Headlights are added");
        }
        public void EndOperations()
        {
            product.Add("-----------");
        }
        public ProductSpecification GetVehicle()
        {
            return product;
        }
    }
}