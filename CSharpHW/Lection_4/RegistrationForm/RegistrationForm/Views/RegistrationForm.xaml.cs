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
using RegistrationForm.Validators;

namespace RegistrationForm.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class RegistrationForm : Window
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void FirstNameTBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(RegistrationFormValidator.IsValidFirstName(FirstNameTBox.Text))
            {
                FirstNameMistakeTBlock.Visibility = System.Windows.Visibility.Hidden;

                if(RegistrationFormValidator.IsAllInputValid)
                {
                    SendButton.IsEnabled = true;
                }
                else
                {
                    SendButton.IsEnabled = false;
                }
            }
            else
            {
                SendButton.IsEnabled = false;
                FirstNameMistakeTBlock.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void LastNameTBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (RegistrationFormValidator.IsValidLastName(LastNameTBox.Text))
            {
                LastNameMistakeTBlock.Visibility = System.Windows.Visibility.Hidden;

                if (RegistrationFormValidator.IsAllInputValid)
                {
                    SendButton.IsEnabled = true;
                }
                else
                {
                    SendButton.IsEnabled = false;
                }
            }
            else
            {
                SendButton.IsEnabled = false;
                LastNameMistakeTBlock.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void BirthDayTBox_TextChanged(object sender, TextChangedEventArgs e)
        {
                var birthDatePattern = "{0}.{1}.{2}";
                string birthDate = string.Format(birthDatePattern, BirthDayTBox.Text, BirthMonthTBox.Text, BirthYearTBox.Text);

                DateTime probeForOutParameter;

                if (RegistrationFormValidator.TryParseBirthDate(birthDate, out probeForOutParameter))
                {
                    BirthDateMistakeTBlock.Visibility = System.Windows.Visibility.Hidden;
                    if (RegistrationFormValidator.IsAllInputValid)
                    {
                        SendButton.IsEnabled = true;
                    }
                    else
                    {
                        SendButton.IsEnabled = false;
                    }
                }
                else
                {
                    if (BirthMonthTBox.Text == string.Empty || BirthYearTBox.Text == string.Empty)
                    {
                        BirthDateMistakeTBlock.Visibility = System.Windows.Visibility.Hidden;
                    }
                    else
                    {
                        SendButton.IsEnabled = false;
                        BirthDateMistakeTBlock.Visibility = System.Windows.Visibility.Visible;
                    }
                }
        }

        private void BirthMonthTBox_TextChanged(object sender, TextChangedEventArgs e)
        {
                var birthDatePattern = "{0}.{1}.{2}";
                string birthDate = string.Format(birthDatePattern, BirthDayTBox.Text, BirthMonthTBox.Text, BirthYearTBox.Text);

                DateTime probeForOutParameter;

                if (RegistrationFormValidator.TryParseBirthDate(birthDate, out probeForOutParameter))
                {
                    BirthDateMistakeTBlock.Visibility = System.Windows.Visibility.Hidden;

                    if (RegistrationFormValidator.IsAllInputValid)
                    {
                        SendButton.IsEnabled = true;
                    }
                    else
                    {
                        SendButton.IsEnabled = false;
                    }
                }
                else
                {
                    if (BirthDayTBox.Text == string.Empty || BirthYearTBox.Text == string.Empty)
                    {
                        BirthDateMistakeTBlock.Visibility = System.Windows.Visibility.Hidden;
                    }
                    else
                    {
                        SendButton.IsEnabled = false;
                        BirthDateMistakeTBlock.Visibility = System.Windows.Visibility.Visible;
                    }
                }
        }

        private void BirthYearTBox_TextChanged(object sender, TextChangedEventArgs e)
        {
                var birthDatePattern = "{0}.{1}.{2}";
                string birthDate = string.Format(birthDatePattern, BirthDayTBox.Text, BirthMonthTBox.Text, BirthYearTBox.Text);

                DateTime probeForOutParameter;

                if (RegistrationFormValidator.TryParseBirthDate(birthDate, out probeForOutParameter))
                {
                    BirthDateMistakeTBlock.Visibility = System.Windows.Visibility.Hidden;

                    if (RegistrationFormValidator.IsAllInputValid)
                    {
                        SendButton.IsEnabled = true;
                    }
                    else
                    {
                        SendButton.IsEnabled = false;
                    }
                }
                else
                {
                    if (BirthDayTBox.Text == string.Empty || BirthMonthTBox.Text == string.Empty)
                    {
                        BirthDateMistakeTBlock.Visibility = System.Windows.Visibility.Hidden;
                    }
                    else
                    {
                        SendButton.IsEnabled = false;
                        BirthDateMistakeTBlock.Visibility = System.Windows.Visibility.Visible;
                    }
                }
        }

        private void GenderCBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RegistrationFormValidator.isValidGender(GenderCBox.SelectedItem.ToString().Substring(38)))
            {
                GenderMistakeTBlock.Visibility = System.Windows.Visibility.Hidden;

                if (RegistrationFormValidator.IsAllInputValid)
                {
                    SendButton.IsEnabled = true;
                }
                else
                {
                    SendButton.IsEnabled = false;
                }
            }
            else
            {
                SendButton.IsEnabled = false;
                GenderMistakeTBlock.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void EmailTBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (RegistrationFormValidator.IsValidEmail(EmailTBox.Text))
            {
                EmailMistakeTBlock.Visibility = System.Windows.Visibility.Hidden;

                if (RegistrationFormValidator.IsAllInputValid)
                {
                    SendButton.IsEnabled = true;
                }
                else
                {
                    SendButton.IsEnabled = false;
                }
            }
            else
            {
                SendButton.IsEnabled = false;
                EmailMistakeTBlock.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void PhoneNumberTBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (RegistrationFormValidator.IsValidPhoneNumber(PhoneNumberTBox.Text))
            {
                PhoneNumberMistakeTBlock.Visibility = System.Windows.Visibility.Hidden;

                if (RegistrationFormValidator.IsAllInputValid)
                {
                    SendButton.IsEnabled = true;
                }
                else
                {
                    SendButton.IsEnabled = false;
                }
            }
            else
            {
                SendButton.IsEnabled = false;
                PhoneNumberMistakeTBlock.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void AdditionalInformaitionTBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (RegistrationFormValidator.IsValidAdditionalInfo(AdditionalInformaitionTBox.Text))
            {
                AdditionalInformationMistakeTBlock.Visibility = System.Windows.Visibility.Hidden;

                if (RegistrationFormValidator.IsAllInputValid)
                {
                    SendButton.IsEnabled = true;
                }
                else
                {
                    SendButton.IsEnabled = false;
                }
            }
            else
            {
                SendButton.IsEnabled = false;
                AdditionalInformationMistakeTBlock.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your registration form has been successfully sent! Thank you for your time, good luck!");
        }


    }
}
