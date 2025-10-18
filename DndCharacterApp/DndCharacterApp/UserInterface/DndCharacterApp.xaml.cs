using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DndCharacterApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class DndCharacterApp_Window : Window
    {
        public DndCharacterApp_Window()
        {
            InitializeComponent();
        }



        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }



        private void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }



        private void OpenCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }



        /// <summary>
		/// closes the program
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CloseCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }



        /// <summary>
        /// verifys player has saved before closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DndCharacter_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }//end of DndCharacterApp_Window
}//end of nameSpace