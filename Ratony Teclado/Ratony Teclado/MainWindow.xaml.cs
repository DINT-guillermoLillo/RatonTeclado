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

namespace Ratony_Teclado
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

        // FOCUS ---------------------------------------------------------------------------------- 

        private void TextBox_GotKeyboardFocus (object sender, RoutedEventArgs e)
        {
            focoTextBox.Text = ((TextBox)sender).Name;
        }

        //TextBox RATON SOBRE ----------------------------------------------------------------------------------
        private void TextBlock_GotMouseCapture(object sender, MouseEventArgs e)
        {
            ratonTextBox.Text = "TextBlock 1";
        }

        private void MayusculasTextBox_GotMouseCapture(object sender, MouseEventArgs e)
        {
            ratonTextBox.Text = "TextBox 1";
        }

        private void AyudaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
          //  if (e.key == Key.F1)
          //      AyudaTextBox.Text = "AYUDA";
        }

        private void TextBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ratonTextBox.Text = ((TextBox)sender).Name;
        }
    }
}
