using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPatternExample
{
    public class ExcelDocumentFactory:DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new ExcelDocument();
        }
    }
}
