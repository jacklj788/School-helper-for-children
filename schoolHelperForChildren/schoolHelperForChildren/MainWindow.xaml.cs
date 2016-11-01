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
        Student student1;
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

            /*
            tries to write to the file, otherwise catches it so it doesn't crash.
            try
            {
                // Located in bin > Debug 
                // Writes the persons name into the notepad file to store.
                using (StreamWriter writer = new StreamWriter("UserData.txt"))
                {
                    writer.Write(nameTxtbox.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!");
            }
            */
        }
    }
}
