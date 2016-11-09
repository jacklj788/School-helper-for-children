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
        int score = 0;
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
            if (beenClicked[0] == false) score++;
            // It will be reset back to false when they hit the submit / check marks button. Allowing them to try again. 
            beenClicked[0] = true;

            qOneRightBtn.Background = Brushes.Aqua;
            qOneWrongBtn.Background = Brushes.AliceBlue;
        }

        private void qOneWrongBtn_Click(object sender, RoutedEventArgs e)
        {
            qOneWrongBtn.Background = Brushes.Aqua;
            qOneRightBtn.Background = Brushes.AliceBlue;
        }
    }
}
