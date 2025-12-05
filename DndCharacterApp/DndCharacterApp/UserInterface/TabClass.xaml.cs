using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DndCharacterApp.UserInterface
{
    /// <summary>
    /// Interaction logic for TabClass.xaml
    /// </summary>
    public partial class TabClass : UserControl
    {
        public ObservableCollection<string> classes = new ObservableCollection<string>() { "Barbarian", "Bard" };
        public TabClass()
        {
            InitializeComponent();
        }

        private void comboClassLevel1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string theClass = comboClassLevel1.SelectedItem.ToString() ?? "NULL";
            theClass = theClass.Remove(0, 38);
            MessageBox.Show(theClass);
        }
    }
}
