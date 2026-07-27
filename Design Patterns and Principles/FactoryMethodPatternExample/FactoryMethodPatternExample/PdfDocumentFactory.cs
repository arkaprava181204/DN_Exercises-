using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPatternExample
{
    public class PdfDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new PdfDocument();
        }
    }
}
