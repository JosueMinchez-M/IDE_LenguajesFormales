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

namespace IDE_FirstProject
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
        private void CrearMenu_item_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has Presionado el Item Crear");
            //rtb_escribirCodigo.
        }
        public void verFilaColumna()
        {
            TextPointer tp1 = rtb_escribirCodigo.Selection.Start.GetLineStartPosition(0);
            TextPointer tp2 = rtb_escribirCodigo.Selection.Start;

            int column = tp1.GetOffsetToPosition(tp2);

            int someBigNumber = int.MaxValue;
            int lineMoved, currentLineNumber;
            rtb_escribirCodigo.Selection.Start.GetLineStartPosition(-someBigNumber, out lineMoved);
            currentLineNumber = -lineMoved;

            lbl_FilaColumna.Content = "Line: " + currentLineNumber.ToString() + " Column: " + column.ToString();
        }

        private void btn_Compilar_Click(object sender, RoutedEventArgs e)
        {
            verFilaColumna();
        }

        private void rtb_escribirCodigo_KeyPress(Object sender, AccessKeyPressedEventArgs e)
        {
            if ()
            {

            }
        }
    }
}
