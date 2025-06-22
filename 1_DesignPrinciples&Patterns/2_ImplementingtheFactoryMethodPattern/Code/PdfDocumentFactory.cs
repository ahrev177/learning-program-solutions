using FactoryPattern.Documents;

namespace FactoryPattern.Factories
{
    public class PdfDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument() => new PdfDocument();
    }
}