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
using MinMaxDefaultWPF.Controller;

namespace MinMaxDefaultWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private MainWindowController _controller;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            _controller = new MainWindowController(this);
        }

        private void NumericTypeCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _controller.DisplayData(NumericTypeCB.SelectedItem);
        }
    }
}
