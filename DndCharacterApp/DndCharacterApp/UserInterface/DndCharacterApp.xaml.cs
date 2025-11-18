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
        private bool saveEnabled = false;
        private bool saveCanceled = false;
        private string? fileName;
        public static event Action? UpdateTabs;

        public DndCharacterApp_Window()
        {
            InitializeComponent();
            Player.StaticPropertyChanged += UpdateStats;
            SaveCommand.IsEnabled = false;
        }



        /// <summary>
        /// clears all player data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBoxResult mbr = MessageBox.Show("Would you like to save your changes?", "Save", MessageBoxButton.YesNoCancel);
            if (mbr == MessageBoxResult.Yes && saveEnabled)
            {
                SaveCommand_Executed(sender, e);
            }
            else if(mbr == MessageBoxResult.Yes && !saveEnabled)
            {
                SaveAsCommand_Executed(sender, e);
            }
            else if(mbr == MessageBoxResult.Cancel)
            {
                return;
            }
            Player.RemoveStats();
            UpdateTabs?.Invoke();
        }



        /// <summary>
        /// saves player data without prompt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Save();
        }
        private void Save()
        {
            if (fileName == null)
            {
                return;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(Player_NonStatic));
            try
            {
                using (FileStream file = new FileStream(fileName, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(file))
                    {
                        serializer.Serialize(sw, new Player_NonStatic());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        /// <summary>
        /// saves player data with a prompt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAsCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveAs();
        }//end of save as command
        private void SaveAs()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save As";
            if (Player.Name.ToString() == string.Empty)
            {
                sfd.FileName = "idk";
            }
            else
            {
                sfd.FileName = Player.Name.ToString();
            }
            sfd.Filter = "XML (.xml)|*.xml";

            if (sfd.ShowDialog() != true)
            {
                saveCanceled = true;
                return;
            }

            fileName = sfd.FileName;
            XmlSerializer serializer = new XmlSerializer(typeof(Player_NonStatic));

            try
            {
                using (FileStream file = new FileStream(fileName, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(file))
                    {
                        serializer.Serialize(sw, new Player_NonStatic());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            saveEnabled = true;
        }



        /// <summary>
        /// opens a file containing player data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open";
            ofd.Filter = "XML (.xml)|*.xml";

            if (ofd.ShowDialog() != true)
            {
                return;
            }

            string fileName = ofd.FileName;
            XmlSerializer serializer = new XmlSerializer(typeof(Player_NonStatic));

            try
            {
                using (FileStream file = new FileStream(fileName, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        Player_NonStatic? player = (Player_NonStatic?)serializer.Deserialize(sr);
                        if(player != null)
                        {
                            Player.ImportStats(player);
                        }
                        else
                        {
                            throw new Exception("Imported Character is Null");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            saveEnabled = true;
            UpdateTabs?.Invoke();
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
            MessageBoxResult mbr = MessageBox.Show("Would you like to save your changes?", "Save", MessageBoxButton.YesNoCancel);
            if (mbr == MessageBoxResult.Yes && saveEnabled)
            {
                Save();
            }
            else if (mbr == MessageBoxResult.Yes && !saveEnabled)
            {
                SaveAs();
                if(saveCanceled)
                {
                    e.Cancel = true;
                    return;
                }
            }
            else if (mbr == MessageBoxResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
            saveCanceled = false;
        }
    }//end of DndCharacterApp_Window
}//end of nameSpace