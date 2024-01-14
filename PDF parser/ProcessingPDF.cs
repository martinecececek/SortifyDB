using Spire.Pdf;
using System.IO.Compression;
using System.Xml;

namespace SortifyDB.PDF_parser
{
    public partial class ProcessingPDF : Form
    {
        public ProcessingPDF(string pdfPath)
        {
            InitializeComponent();

            _pdfPath = pdfPath;
        }

        private readonly string _pdfPath;
        private readonly string _originalCurrentDir = Directory.GetCurrentDirectory();
        private static readonly string _newCurrentDirectory = Directory.GetCurrentDirectory() + @"\ConvertedDirecotory";

        private void ProcessingPDF_Load(object sender, EventArgs e)
        {

        }

        private async void ProcessPDF()
        {
            progressBar1.Value = 0;
            processLabel.Text = "Příprava PDF souboru...";

            #region create temp dir for data saving

            processLabel.Text = "Vytváření dočasné složky...";

            Thread thread = new(() => UpdateProgressBar(progressBar1, 13));
            thread.Start();

            Directory.CreateDirectory(_newCurrentDirectory);
            Directory.SetCurrentDirectory(_newCurrentDirectory);

            thread.Join();
            thread.Abort();
            #endregion

            #region convert pdf to docx

            processLabel.Text = "Načítání dat z pdf...";
            Thread thread1 = new(() => UpdateProgressBar(progressBar1, 13));
            thread1.Start();

            PdfDocument pdfDoc = new();

            pdfDoc.LoadFromFile(_pdfPath);
            pdfDoc.SaveToFile("ConvertedPdf.docx", FileFormat.DOCX);

            pdfDoc.Clone();
            pdfDoc.Close();

            thread.Join();
            thread.Abort();

            #endregion

            #region convert docx to xml

            processLabel.Text = "Čtení dat v pdf...";
            Thread thread2 = new(() => UpdateProgressBar(progressBar1, 13));
            thread2.Start();

            string docxPath = System.IO.Path.Combine(_newCurrentDirectory, "ConvertedPdf.docx");
            string zipPath = System.IO.Path.ChangeExtension(docxPath, "TMP.zip");
            string extractedPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "unzip");

            // create temp zip
            File.Copy(docxPath, zipPath, true);

            // extract xml from zip
            ZipFile.ExtractToDirectory(zipPath, extractedPath);

            // Read the XML content
            string xmlPath = System.IO.Path.Combine(extractedPath, "word", "document.xml");
            XmlDocument xmlDoc = new();
            xmlDoc.Load(xmlPath);

            thread2.Join();
            thread2.Abort();

            #endregion

            #region create shadow copy of xml

            string shadowCopyPath = System.IO.Path.Combine(_originalCurrentDir, "ShadowCopy.xml");
            File.Copy(xmlPath, shadowCopyPath, true);

            #endregion

            #region get data from xml

            processLabel.Text = "Extrahování dat z pdf...";
            Thread thread3 = new(() => UpdateProgressBar(progressBar1, 13));
            thread3.Start();

            XmlNamespaceManager nsmgr = new(xmlDoc.NameTable);
            nsmgr.AddNamespace("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");

            XmlNodeList nodes = xmlDoc.SelectNodes("//w:document/w:body/w:p/w:r/w:t", nsmgr);

            List<string> xmlValues = new();
            foreach (XmlNode node in nodes)
            {
                xmlValues.Add(node.InnerText.ToString());
            }

            thread3.Join();
            thread3.Abort();

            #endregion

            #region load data from csv

            processLabel.Text = "Kontrola extrahovaných dat";
            Thread thread4 = new(() => UpdateProgressBar(progressBar1, 13));
            thread4.Start();

            string csvPath = Path.Combine(_originalCurrentDir, "unnesesseryData.csv");
            List<string> csvValues = File.ReadAllLines(csvPath).ToList();

            thread4.Join();
            thread4.Abort();

            #endregion

            #region compare csv and xml data and delete duplicates

            processLabel.Text = "Kontrola extrahovaných dat";
            Thread thread5 = new(() => UpdateProgressBar(progressBar1, 13));
            thread5.Start();

            foreach (string xmlValue in xmlValues)
            {
                xmlValue.Trim().ToLower();

                foreach (string csvValue in csvValues)
                {
                    csvValue.Trim().ToLower();
                    if (csvValue == xmlValue)
                    {
                        xmlValues.Remove(xmlValue);
                    }
                }
            }

            thread5.Join();
            thread5.Abort();

            #endregion

            #region done and loading is 100%

            processLabel.Text = "Hotovo";
            progressBar1.Value = 100;

            Thread.Sleep(2000);

            this.Close();

            #endregion

        }

        private void UpdateProgressBar(ProgressBar progressBar, int increase)
        {
            for (int i = 0; i < increase; i++)
            {
                progressBar.Value++;
                Thread.Sleep(100);
            }
        }
    }
}
