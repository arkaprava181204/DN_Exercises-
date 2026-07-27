using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPatternExample
{
    public class WordDocumentFactory: DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new WordDocument();
        }
    }
}
