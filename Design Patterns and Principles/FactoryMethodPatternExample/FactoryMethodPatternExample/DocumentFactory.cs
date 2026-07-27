using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPatternExample
{
    public abstract class DocumentFactory
    {
        public abstract IDocument CreateDocument();
    }
}
