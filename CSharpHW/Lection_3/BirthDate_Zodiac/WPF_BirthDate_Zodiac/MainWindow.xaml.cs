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
using DateHandlerLibrary;
using DateHandlerLibrary.Pathfinder;
using DateHandlerLibrary.RunEnum;

namespace WPF_BirthDate_Zodiac
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExploreButton_Click(object sender, RoutedEventArgs e)
        {
            DateTime userDateOfBirth = BirthDateParser.TryParseBirthDate(BirthDateTBox.Text, ProgramEnums.WPF);

            if (userDateOfBirth.Equals(DateTime.MinValue))
            {
                BirthDateTBox.Text = string.Empty;
                MessageBox.Show("You entered invalid data! Please try again!");
            }
            else
            {
                ShortInfoTBck.Text = string.Format("Your age is {0} and your zodiac sigh is {1}", AgeFinder.DetermineAge(userDateOfBirth), ZodiacExplorer.DetermineZodiacSign(userDateOfBirth));

                var pathfinder = new ImagesPathfinder();

                var Icon = new Image();
                Icon.Source = new BitmapImage(new Uri(pathfinder.PathForIcons(ZodiacExplorer.DetermineZodiacSign(userDateOfBirth))));
                ZodiacSignIconGrid.Children.Add(Icon);
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
