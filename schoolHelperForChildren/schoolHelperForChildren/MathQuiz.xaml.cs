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
        double[] answers = new double[6];
        public MathQuiz()
        {
            InitializeComponent();

            Random rnd = new Random();
            // Doubles because division might require it
            double[] numbers = new double[12];

            List<Label> lblList = new List<Label>();
            // Better way to do this? Don't think there is sadly. But it's better this than it was before because now I can do foreach loops
            lblList.Add(num1Lbl);
            lblList.Add(num2Lbl);
            lblList.Add(num3Lbl);
            lblList.Add(num4Lbl);
            lblList.Add(num5Lbl);
            lblList.Add(num6Lbl);
            lblList.Add(num7Lbl);
            lblList.Add(num8Lbl);
            lblList.Add(num9Lbl);
            lblList.Add(num10Lbl);
            lblList.Add(num11Lbl);
            lblList.Add(num12Lbl);

            // Will put this in a foreach loop later - Declares the variables as random numbers between 1 and 20. 20 is a good enough number for children
            int i = 0;
            foreach (double equationNumbers in numbers)
            {
                // Populates the numbers
                numbers[i] = rnd.Next(1, 20);
                // this is the one drawback with foreach loops. Can't use [d] because it's a double not an int. 
                i++;
            }
            // add
            answers[0] = (numbers[0] + numbers[1]);
            answers[1] = (numbers[2] + numbers[3]);
            answers[2] = (numbers[4] + numbers[5]);
            // minus
            answers[3] = (numbers[6] - numbers[7]);
            // multiply 
            answers[4] = (numbers[8] * numbers[9]);
            answers[5] = (numbers[10] / numbers[11]);

            // numLoop = makes sure it populates the next array slot each time
            int numLoop = 0;
            foreach (Label l in lblList)
            {
                l.Content = numbers[numLoop];
                numLoop++;
            }
        }

        private void submitAnswersTxtbox_Click(object sender, RoutedEventArgs e)
        {
            // Floats werent working as float parsing was breaking, but double converting is fine. 
            // Needs to be the same as how many text boxes there are (half the numbers).
            double[] textBoxToNumber = new double[6];
            int i = 0;
            int score = 0;
            // This is the solution to my bug. This bool makes it so ONLY the message box saying "input values in each box" OR the score pops up. Not both. 
            // This way the score won't show to the user that it isn't actually working. 
            bool only1MessageBox;
            // Converts the textbox content from a string to a double
            try
            {
                // If these are empty, it won't work. This is the issue with Try catching, it isn't making sure there is a value.
                // If no value it skips it. Breaking the score system as it compares i to i (1 to 1) but what is 1 is null? weird.
                textBoxToNumber[0] = Convert.ToDouble(answer1Txtbox.Text);
                textBoxToNumber[1] = Convert.ToDouble(answer2Txtbox.Text);
                textBoxToNumber[2] = Convert.ToDouble(answer3Txtbox.Text);
                textBoxToNumber[3] = Convert.ToDouble(answer4Txtbox.Text);
                textBoxToNumber[4] = Convert.ToDouble(answer5Txtbox.Text);
                // Converts it into a 2 decimal place numbers (such as 1.5) instead of say (1.5457345834)... kids won't ever expect that, but rounding up is common. 
                Math.Round(textBoxToNumber[5] = Convert.ToDouble(answer6Txtbox.Text), 2); 
                only1MessageBox = false;
            }
            catch (Exception failedToConvert)
            {
                //Commented out while i debug since it gets annoying!
                MessageBox.Show("You forgot to answer a question!\nJust take a guess if you don't know, it's better than leaving it blank.");
                // It failed so we make it so only this message box shows.
                only1MessageBox = true;

            }


            foreach (double a in answers)
            {
                if (textBoxToNumber[i] == answers[i])
                {
                    score++;
                }
                // Moved this out of the code, it needs to update every time not just when it's correct. - Error still here. 
                i++;
            }

            //MessageBox.Show(String.Format("{0}", score));
            // Commented out while I debug since it gets annoying! 
            if (score > 4)
            {
                // Is there another warning message box more important?
                if (only1MessageBox == false)
                {
                    // If not then show the score
                    MessageBox.Show(String.Format("You scored {0} / 6 correct!", score));
                    returnBtn.Visibility = Visibility.Visible;
                }
            }
            else
            {
                // Being designed for children so we need to watch our language tone, can't just tell them they failed, that's not reinforcing. 
                if (only1MessageBox == false)
                {
                    MessageBox.Show(String.Format("You only scored {0} / 6 correct. Try again.", score));
                }
            }
        }

        private void returnBtn_Click(object sender, RoutedEventArgs e)
        {
            SubjectSelection sS = new SubjectSelection();
            this.Content = sS;
        }
    }
}
