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

namespace schoolHelperForChildren
{
    /// <summary>
    /// Interaction logic for EnglishQuiz.xaml
    /// </summary>
    public partial class EnglishQuiz : UserControl
    {
        // Using an array and not just 1 number so it can act as a switch. could technically be bools too.
        // Otherwise if they answer it correctly but then switch their answer before submitting it will still think they got it correctly.
        // And we can't just have the wrong answer - 1 otherwise it could confuse them as to what one is wrong. 
        int[] score = { 0, 0, 0, 0 };
        bool[] beenClicked = new bool[4];
        public EnglishQuiz()
        {
            InitializeComponent();
            int i = 0;
            foreach (bool b in beenClicked)
            {
                beenClicked[i] = false;
                i++;
            }
        }

        private void qOneRightBtn_Click(object sender, RoutedEventArgs e)
        {
            // This makes sure it doesn't add to their score every single time they click the button. This way it can only happen once.
            if (beenClicked[0] == false) score[0] = 1;
            // It will be reset back to false when they hit the submit / check marks button. Allowing them to try again. 
            beenClicked[0] = true;

            // Swaps out
            qOneRightBtn.Background = Brushes.Aqua;
            qOneWrongBtn.Background = Brushes.AliceBlue;
        }

        private void qOneWrongBtn_Click(object sender, RoutedEventArgs e)
        {
            score[0] = 0;
            qOneWrongBtn.Background = Brushes.Aqua;
            qOneRightBtn.Background = Brushes.AliceBlue;
        }

        private void qTwoRightBtn_Click(object sender, RoutedEventArgs e)
        {
            if (beenClicked[1] == false) score[1] = 1;
            // It will be reset back to false when they hit the submit / check marks button. Allowing them to try again. 
            beenClicked[1] = true;

            // Swaps out
            qTwoRightBtn.Background = Brushes.Aqua;
            qTwoWrongBtn.Background = Brushes.AliceBlue;
        }

        private void qTwoWrongBtn_Click(object sender, RoutedEventArgs e)
        {
            score[1] = 0;
            qTwoWrongBtn.Background = Brushes.Aqua;
            qTwoRightBtn.Background = Brushes.AliceBlue;
        }

        private void qThreeRightBtn_Click(object sender, RoutedEventArgs e)
        {
            if (beenClicked[2] == false) score[2] = 1;
            // It will be reset back to false when they hit the submit / check marks button. Allowing them to try again. 
            beenClicked[2] = true;

            // Swaps out
            qThreeRightBtn.Background = Brushes.Aqua;
            qThreeWrongBtn.Background = Brushes.AliceBlue;
        }

        private void qThreeWrongBtn_Click(object sender, RoutedEventArgs e)
        {
            score[2] = 0;
            qThreeWrongBtn.Background = Brushes.Aqua;
            qThreeRightBtn.Background = Brushes.AliceBlue;
        }

        private void qFourRightBtn_Click(object sender, RoutedEventArgs e)
        {
            if (beenClicked[3] == false) score[3] = 1;
            // It will be reset back to false when they hit the submit / check marks button. Allowing them to try again. 
            beenClicked[3] = true;

            // Swaps out
            qFourRightBtn.Background = Brushes.Aqua;
            qFourWrongBtn.Background = Brushes.AliceBlue;
        }

        private void qFourWrongBtn_Click(object sender, RoutedEventArgs e)
        {
            score[3] = 0;
            qFourWrongBtn.Background = Brushes.Aqua;
            qFourRightBtn.Background = Brushes.AliceBlue;
        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            int scoreTotal = (score[0] + score[1] + score[2] + score[3]);
            MessageBox.Show(String.Format("You scored {0} / 4", scoreTotal));
        }
    }
}
