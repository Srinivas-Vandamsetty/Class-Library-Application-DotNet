using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProject.SolidPrinciples
{

    // Separate interfaces for specific functionalities
    public interface IPrinter
    {
        void Print(string content);
    }

    public interface IScanner
    {
        void Scan(string content);
    }

    public interface IFax
    {
        void Fax(string content);
    }

    // Basic printer only implements the IPrinter interface
    public class BasicPrinter : IPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine($"Basic Printing: {content}");
        }
    }

    // Advanced printer implements IPrinter, IScanner, and IFax interfaces
    public class AdvancedPrinter : IPrinter, IScanner, IFax
    {
        public void Print(string content)
        {
            Console.WriteLine($"Advance Printing: {content}");
        }

        public void Scan(string content)
        {
            Console.WriteLine($"Advance Scanning: {content}");
        }

        public void Fax(string content)
        {
            Console.WriteLine($"Advance Faxing: {content}");
        }
    }
}

