using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPatternExample
{
    public class WordDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Word Document Opened.");
        }
    }
}
