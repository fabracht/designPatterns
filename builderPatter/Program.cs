using System;

namespace builderPatter
{
    // This example of the builder pattern uses the Main method as the Director Class. This means that the logic behind building the HTML element is not within a separate class, but inside the main method. This is just for simplicity sake.
    partial class Program
    {
        static void Main(string[] args)
        {
            // First we create our div
            var div = new HtmlBuilder("div");
            // And our ul element
            var builder = new HtmlBuilder("ul");

            // Console.WriteLine(div.ToString());
            builder.AddChild("li", "Hello");
            builder.AddChild("li", "World");
            div.AddChild("", builder.ToString());

            Console.WriteLine(builder.ToString());
            Console.WriteLine(div.ToString());
        }

    }


}
