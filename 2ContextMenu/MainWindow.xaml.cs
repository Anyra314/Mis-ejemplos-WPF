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

namespace _2ContextMenu
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MenuChange(Object sender, RoutedEventArgs ags) 
        {
            RadioButton rb = sender as RadioButton;
            if (rb == null || cxm == null) return;

            switch (rb.Name) //al hacer click en uno de los radioButton
            {
                case "rbCustom":
                    cxmTextBox.ContextMenu = cxm;
                    break;
                case "rbDefault":
                    // Clearing the value of the ContextMenu property
                    // restores the default TextBox context menu.
                    cxmTextBox.ClearValue(ContextMenuProperty);
                    break;
                case "rbDisabled":
                    // Setting the ContextMenu propety to
                    // null disables the context menu.
                    cxmTextBox.ContextMenu = null;
                    break;
                default:
                    break;
            }
        }
        //al iniciar el programa, al seleccionar algo del texto y click derecho,salen opciones que podemos hacer
        void ClickPaste(Object sender, RoutedEventArgs args) { cxmTextBox.Paste(); }
        void ClickCopy(Object sender, RoutedEventArgs args) { cxmTextBox.Copy(); }
        void ClickCut(Object sender, RoutedEventArgs args) { cxmTextBox.Cut(); }
        void ClickSelectAll(Object sender, RoutedEventArgs args) { cxmTextBox.SelectAll(); }
        void ClickClear(Object sender, RoutedEventArgs args) { cxmTextBox.Clear(); }
        void ClickUndo(Object sender, RoutedEventArgs args) { cxmTextBox.Undo(); }
        void ClickRedo(Object sender, RoutedEventArgs args) { cxmTextBox.Redo(); }

        void ClickSelectLine(Object sender, RoutedEventArgs args)
        {
            int lineIndex = cxmTextBox.GetLineIndexFromCharacterIndex(cxmTextBox.CaretIndex);
            int lineStartingCharIndex = cxmTextBox.GetCharacterIndexFromLineIndex(lineIndex);
            int lineLength = cxmTextBox.GetLineLength(lineIndex);
            cxmTextBox.Select(lineStartingCharIndex, lineLength);
        }

        void CxmOpened(Object sender, RoutedEventArgs args)
        {
            // Only allow copy/cut if something is selected to copy/cut.
            if (cxmTextBox.SelectedText == "")
                cxmItemCopy.IsEnabled = cxmItemCut.IsEnabled = false;
            else
                cxmItemCopy.IsEnabled = cxmItemCut.IsEnabled = true;

            // Only allow paste if there is text on the clipboard to paste.
            if (Clipboard.ContainsText())
                cxmItemPaste.IsEnabled = true;
            else
                cxmItemPaste.IsEnabled = false;
        }
    }
}
