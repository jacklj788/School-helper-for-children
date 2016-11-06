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
    
    public partial class MathQuiz : UserControl
    {
        // There will be half as many answers as numbers - it's 1 for now but will grow, which is why its an array
        // Its in the class but outside of the constructor so all functions can access it
        double[] answers = new double[4];
        public MathQuiz()
        {
            InitializeComponent();

            Random rnd = new Random();
            // Doubles because division might require it
            double[] numbers = new double[8];

            List<Label> lblList = new List<Label>();
            // Better way to do this? Don't think there is sadly. 
            lblList.Add(num1Lbl);
            lblList.Add(num2Lbl);
            lblList.Add(num3Lbl);
            lblList.Add(num4Lbl);
            lblList.Add(num5Lbl);
            lblList.Add(num6Lbl);
            lblList.Add(num7Lbl);
            lblList.Add(num8Lbl);

            // Will put this in a foreach loop later - Declares the variables as random numbers between 1 and 45. 45 is a good max number for children 
            int i = 0;
            foreach (double d in numbers)
            {
                numbers[i] = rnd.Next(1, 45);
                // this is the one drawback with foreach loops. Can't use [d] because it's a double not an int. 
                i++;
            }


            // Need a nicer way for this too
            // addition
            answers[0] = (numbers[0] + numbers[1]);
            answers[1] = (numbers[2] + numbers[3]);
            answers[2] = (numbers[4] + numbers[5]);
            // minus
            answers[2] = (numbers[6] - numbers[7]);

            // numLoop = makes sure it populates the next array slot each time
            int numLoop = 0;
            foreach(Label l in lblList)
            {
                l.Content = numbers[numLoop];
                numLoop++;
            }
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
