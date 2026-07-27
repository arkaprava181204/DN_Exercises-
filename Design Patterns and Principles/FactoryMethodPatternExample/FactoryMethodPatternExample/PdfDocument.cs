using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPatternExample
{
    public class PdfDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("PDF Document Opened.");
        }
    }
}
