using System.Windows.Controls;
using DevExpress.XtraPrinting;
using DevExpress.XtraRichEdit;

namespace RtfPdfCreator.Views
{
    /// <summary>
    /// Interaction logic for RtfEditor
    /// </summary>
    public partial class RtfEditor : UserControl
    {
        public RtfEditor()
        {
            InitializeComponent();
            RichEditControl.SaveDocument("SavedDocument.rtf", DocumentFormat.Rtf);
            PdfExportOptions options = new PdfExportOptions();
            options.DocumentOptions.Author = "Mark Jones";
            options.Compressed = false;
            options.ImageQuality = PdfJpegImageQuality.High;
            //Export the document to the file:
            RichEditControl.ExportToPdf("Document.pdf", options);
        }
    }
}
