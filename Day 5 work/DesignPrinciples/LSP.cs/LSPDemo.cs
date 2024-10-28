using DesignPrinciples.LSP;

namespace DesignPrinciples.LSP
{
    internal class LSPDemo
    {
        public void LSPDemoMethod()
        {
            IFruit fruit = new Orange();
            Console.WriteLine("Colour of Orange: " + fruit.GetColour());
            fruit = new Apple();
            Console.WriteLine("Colour of Apple : " + fruit.GetColour());
        }
    }
}