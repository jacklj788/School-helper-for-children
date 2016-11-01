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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Student student1 = new Student();
        public MainWindow()
        {
            InitializeComponent();
        }

        // GotFocus = first time it is clicked / interacted with 
        private void nameTxtbox_GotFocus(object sender, RoutedEventArgs e)
        {
            // Clears the textbox
            nameTxtbox.Text = "";
        }

        private void nameBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Located in bin > Debug 
                // Writes the persons name into the notepad file to store.
                using (StreamWriter writer = new StreamWriter("UserData.txt"))
                {
                    writer.WriteLine(nameTxtbox.Text);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!");
            }
            // Moved this down here otherwise it would run the Reader before doing the Writer
            SubjectSelection subjectTopic = new SubjectSelection();
            this.Content = subjectTopic;
        }
    }
}
