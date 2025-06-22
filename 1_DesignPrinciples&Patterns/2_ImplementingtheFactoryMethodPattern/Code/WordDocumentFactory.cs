using FactoryPattern.Documents;

namespace FactoryPattern.Factories
{
    public class WordDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument() => new WordDocument();
    }
}