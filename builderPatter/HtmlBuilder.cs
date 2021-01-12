namespace builderPatter
{
    public class HtmlBuilder
    {
        HtmlElement root = new HtmlElement();
        private readonly string rootName;

        public HtmlBuilder(string rootName)
        {
            this.rootName = rootName;
            root.Name = rootName;
        }

        public void AddChild(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);
        }

        public override string ToString()
        {
            return root.ToString();
        }

        public void Clear()
        {
            root = new HtmlElement { Name = rootName };
        }
    }
}
