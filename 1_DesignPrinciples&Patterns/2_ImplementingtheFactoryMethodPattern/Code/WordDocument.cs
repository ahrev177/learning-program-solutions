namespace FactoryPattern.Documents
{
    public class WordDocument : IDocument
    {
        public void Open() => Console.WriteLine("Word document opened.");
    }
}