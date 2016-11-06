using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Diagnostics;
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
        // There will be half as many answers as numbers - it's 1 for now but will grow, which is why its an array
        // Its in the class but outside of the constructor so all functions can access it
        double[] answers = new double[3];
        public MathQuiz()
        {
            InitializeComponent();

            Random rnd = new Random();
            // Doubles because division might require it
            double[] numbers = new double[6];

            // Will put this in a foreach loop later - Declares the variables as random numbers between 1 and 45. 45 is a good max number for children 
            int i = 0;
            foreach (double d in numbers)
            {
                // DEBUGGING - These are all being populated correctly
                numbers[i] = rnd.Next(1, 45);
                // this is the one drawback with foreach loops. Can't use [d] because it's a double not an int. 
                i++;
            }


            // Need a nicer way for this too
            // DEBUGGING - These are all correctly being populated 
            answers[0] = (numbers[0] + numbers[1]);
            answers[1] = (numbers[2] + numbers[3]);
            answers[2] = (numbers[4] + numbers[5]);

            // need to think of a better way to do this. How do I put these labels into an array or something of the sort.
            num1Lbl.Content = numbers[0];
            num2Lbl.Content = numbers[1];
            num3Lbl.Content = numbers[2];
            num4Lbl.Content = numbers[3];
            num5Lbl.Content = numbers[4];
            num6Lbl.Content = numbers[5];
        }

        private void submitAnswersTxtbox_Click(object sender, RoutedEventArgs e)
        {
            // Floats werent working as float parsing was breaking, but double converting is fine. 
            double[] textBoxToNumber = new double[3];
            int i = 0;
            int score = 0;
            // Converts the textbox content from a string to a double
            try
            {
                textBoxToNumber[0] = Convert.ToDouble(answer1Txtbox.Text);
                textBoxToNumber[1] = Convert.ToDouble(answer2Txtbox.Text);
                textBoxToNumber[2] = Convert.ToDouble(answer3Txtbox.Text);
            }
            catch (Exception failedToConvert)
            {
                MessageBox.Show("You forgot to answer a question!\nJust take a guess if you don't know, it's better than leaving it blank.");
            }

            foreach (double a in answers)
            {
                if (textBoxToNumber[i] == answers[i])
                {
                    i++;
                    score++;
                }
            }
       
            // DEBUG - change this value in the future!! Aim for them to require 70-80% correct. 
            if (score > 1)
            {
                // Just here so i know it's working. The label is useless though. 
                label.Visibility = Visibility.Visible;
            }
            else
            {
                // Being designed for children so we need to watch our language tone, can't just tell them they failed, that's not reinforcing. 
                Console.WriteLine("Almost! try again and you'll get it done!");
            }
        }
    }
}
