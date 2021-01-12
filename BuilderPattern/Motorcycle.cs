namespace BuilderPattern
{
    public class Motorcycle : IBuilder
    {
        private ProductSpecification product;
        private readonly string _brandName;

        public Motorcycle(string brandName)
        {
            _brandName = brandName;
            product = new ProductSpecification();
        }

        public void StartUpOperations()
        {
            product.Add("______________");
        }
        public void BuildBody()
        {
            product.Add("Motorcycle body frame");
        }
        public void InsertWheels()
        {
            product.Add("2 wheels added");
        }
        public void AddHeadlights()
        {
            product.Add("1 headlight added");
        }
        public void EndOperations()
        {
            product.Add($"Motorcycle model name: {this._brandName}");
        }

        public ProductSpecification GetVehicle()
        {
            return product;
        }


    }
}