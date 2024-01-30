using SortifyDB.ManualAddingInterface;
using TechnoWizz.ManualAddingForm.Edit;

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

            if (addOrEdit == "edit")
            {
                GetPreviousTL getPreviousTL = new();
                getPreviousTL.ShowDialog();

                string previousTL = getPreviousTL.TL;

                getPreviousTL.Dispose();

                MainManualAdding mainManualAdding = new();
                mainManualAdding.ChangeMainFormUI(new MainManualAdding());

                mainManualAdding.ChangeUI(new ProjektyEdit(MainForm.Projekty.Find(x => x.TL == previousTL)));

                return;
            }


        }
    }
}
