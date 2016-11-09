using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for SubjectSelection.xaml
    /// </summary>
    public partial class SubjectSelection : UserControl
    {
        public SubjectSelection()
        {
            InitializeComponent();

            string line;
            using (StreamReader reader = new StreamReader("UserData.txt"))
            {
                line = reader.ReadLine();
            }
            nameLbl.Content = ("Hello " + line);
        }

        private void mathBtn_Click(object sender, RoutedEventArgs e)
        {
            // Changes the page to the Mathquiz page when the user selects it.
            MathQuiz math = new MathQuiz();
            this.Content = math;
        }

        private void englishBtn_Click(object sender, RoutedEventArgs e)
        {
            EnglishQuiz english = new EnglishQuiz();
            this.Content = english;
        }
    }
}
