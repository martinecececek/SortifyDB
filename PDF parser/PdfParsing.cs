namespace SortifyDB.PDF_parser
{
    public class PdfParsing
    {
        private static string pdfPath;
        private static string addOrEdit;

        public static void ParsePDF()
        {
            MainPdfParserForm mainPdfParserForm = new();
            mainPdfParserForm.ShowDialog();

            pdfPath = mainPdfParserForm.pdfPath;
            addOrEdit = mainPdfParserForm.addEdit;

            mainPdfParserForm.Dispose();

            if (pdfPath == string.Empty)
            {
                return;
            }

            ProcessingPDF processingPDF = new(pdfPath);
            processingPDF.ShowDialog();

            processingPDF.Dispose();
        }
    }
}
