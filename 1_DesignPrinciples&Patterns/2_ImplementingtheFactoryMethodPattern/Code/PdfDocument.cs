namespace FactoryPattern.Documents
{
    public class PdfDocument : IDocument
    {
        public void Open() => Console.WriteLine("PDF document opened.");
    }
}