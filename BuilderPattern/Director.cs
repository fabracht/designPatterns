namespace BuilderPattern
{
    public class Director
    {
        /* As you can see, the director implements the logic behind the assembly.
        Now let's take a look at what we're building.
        Checkout the ProductSpecification class now. */
        private IBuilder build;

        public void Construct(IBuilder builder)
        {
            this.build = builder;
            builder.StartUpOperations();
            builder.BuildBody();
            builder.InsertWheels();
            builder.AddHeadlights();
            builder.EndOperations();
        }
    }
}