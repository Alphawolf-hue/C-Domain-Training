using DesignPrinciples.DIP;
using DesignPrinciples.ISP;
using DesignPrinciples.LSP;
using DesignPrinciples.OCP;
using DesignPrinciples.SRP;
using System.Text;
namespace DesignPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //SRPDemo srpd = new();
            //srpd.SRPDemoMethod();
            //OCPDemo ocpd = new();
            //ocpd.OCPDemoMethod();
            //LSPDemo lspd = new();
            //lspd.LSPDemoMethod();
            //ISPDemo ispd = new();
            //ispd.ISPDemoMethod();
            // Dependency inversion - states that high level modules should not depend upon low level modules/class
            // both should depend upon abstraction
            // abstraction should not depend upon details but details should depend upon abstraction
            //DIPDemo dipd = new();
            //dipd.DIPDemoMethod();

        }
    }
}
