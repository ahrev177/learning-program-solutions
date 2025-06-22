using FactoryPattern.Documents;

namespace FactoryPattern.Factories
{
    public abstract class DocumentFactory
    {
        public abstract IDocument CreateDocument();
    }
}