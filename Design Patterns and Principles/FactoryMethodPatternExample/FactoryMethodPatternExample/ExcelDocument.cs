using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPatternExample
{
    public class ExcelDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Excel Document Opened.");
        }
    }
}
