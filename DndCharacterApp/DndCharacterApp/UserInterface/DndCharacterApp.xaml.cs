using DndCharacterApp.Objects.Player;
using Microsoft.Win32;
using System.IO;
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
using System.Xml;
using System.Xml.Serialization;

namespace DndCharacterApp.UserInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class DndCharacterApp_Window : Window
    {
        private bool saveEnabled = true;

        public DndCharacterApp_Window()
        {
            InitializeComponent();
            Player.StaticPropertyChanged += UpdateStats;
        }



        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }



        private void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            
        }

        private void SaveAsCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save As";
            if(Player.Name.ToString() == string.Empty)
            {
                sfd.FileName = "idk";
            }
            else
            {
                sfd.FileName = Player.Name.ToString();
            }    
            sfd.Filter = "XML (.xml)|*.xml";

            if(sfd.ShowDialog() != true)
            {
                return;
            }

            string fileName = sfd.FileName;
            XmlSerializer serializer = new XmlSerializer(typeof(Player_NonStatic));

            FileStream file = new FileStream(fileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(file);
            serializer.Serialize(sw, new Player_NonStatic());
            sw.Close();
            file.Close();
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