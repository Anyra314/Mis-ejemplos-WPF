using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _3RichTextBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RichTextBoxExample();
        }

        private void RichTextBoxExample() //creado por código en vez de por xaml
        {

            StackPanel myStackPanel = new StackPanel();

            // Create a FlowDocument to contain content for the RichTextBox.
            FlowDocument myFlowDoc = new FlowDocument();

            // Add paragraphs to the FlowDocument.
            myFlowDoc.Blocks.Add(new Paragraph(new Run("Paragraph 1")));
            myFlowDoc.Blocks.Add(new Paragraph(new Run("Paragraph 2")));
            myFlowDoc.Blocks.Add(new Paragraph(new Run("Paragraph 3")));
            RichTextBox myRichTextBox = new RichTextBox();

            // Add initial content to the RichTextBox.
            myRichTextBox.Document = myFlowDoc;

            test.Children.Add(myRichTextBox);

           // myStackPanel.Children.Add(myRichTextBox);
           // this.Content = myStackPanel;
        }
    }

}
