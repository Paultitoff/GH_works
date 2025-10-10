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
using System.Windows.Shapes;

namespace GitPresentation
{
    /// <summary>
    /// Логика взаимодействия для OutputWindow.xaml
    /// </summary>
    public partial class OutputWindow : Window
    {
        public OutputWindow(string text)
        {
            InitializeComponent();
            OutputTextBlock.Text = text;
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(OutputTextBlock.Text);
            MessageBox.Show("Текст скопирован в буфер обмена", "Копирование", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
