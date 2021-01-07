namespace factoryPattern.types
{
    public interface IKnife
    {
        public EKnifeType knifeType { get; set; }

        public void sharpen();

        public void polish();

        public void package();
    }
}