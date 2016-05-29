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
using GuessTheNumber.RandomGenerator;

namespace GuessTheNumber
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int _randomGeneratedNumber = CustomRandomizer.RandomValue();
        private int _userNumber;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TakeATryButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _userNumber = int.Parse(PlayerInputTBox.Text);
                {
                    if(_userNumber < 1 || _userNumber > 11)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                if (_userNumber.Equals(_randomGeneratedNumber))
                {
                    RandomNumberTBck.Text = _randomGeneratedNumber.ToString();
                    MessageBox.Show("You guessed the number! Сongratulations!");
                }
                else
                {
                    MessageBox.Show("Sorry, but you didn't guess the number, you can try again! Or generate new number.");
                }
            }
            catch(FormatException)
            {
                PlayerInputTBox.Text = string.Empty;
                MessageBox.Show("You input wrong data! Please, try again.");
            }
            catch(ArgumentOutOfRangeException)
            {
                PlayerInputTBox.Text = string.Empty;
                MessageBox.Show("You input invalid number, it must be from 1 to 10! Please, try again.");
            }
        }

        private void GenerateRandomNumberButtom_Click(object sender, RoutedEventArgs e)
        {
            RandomNumberTBck.Text = "?";
            _randomGeneratedNumber = CustomRandomizer.RandomValue();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
