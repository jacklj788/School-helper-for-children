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
    /// Interaction logic for MathQuiz.xaml
    /// </summary>
    public partial class MathQuiz : UserControl
    {
        double[] answers = new double[1];
        public MathQuiz()
        {
            InitializeComponent();

            Random rnd = new Random();

            double[] numbers = new double[2];
            // There will be half as many answers as numbers - it's 1 for now but will grow, which is why its an array

            // Will put this in a foreach loop later - Declares the variables as random numbers between 1 and 45. 45 is a good max number for children 
            numbers[0] = rnd.Next(1, 45);
            numbers[1] = rnd.Next(1, 45);

            answers[0] = (numbers[0] + numbers[1]);

            num1Lbl.Content = numbers[0];
            num2Lbl.Content = numbers[1];
        }

        private void submitAnswersTxtbox_Click(object sender, RoutedEventArgs e)
        {
            // Floats werent working as float parsing was breaking, but double converting is fine. 
            double textBoxToNumber = Convert.ToDouble(answers[0]);
            //num1Lbl.Content = textBoxToNumber;
            if (textBoxToNumber == answers[0])
            {
                label.Visibility = Visibility.Visible;
            }
        }
    }
}
