using FactoryPattern.Documents;

namespace FactoryPattern.Factories
{
    public class ExcelDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument() => new ExcelDocument();
    }
}