using DndCharacterApp.Objects.Player;
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

        private void comboClassLevel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //set all levels to 0
            Player.DruidLevels = 0;

            //initiallize array
            string[] classes = new string[20];

            //get all classes
            string class1 = "";
            string class2 = "";
            string class3 = "";

            if(comboClassLevel1.SelectedItem != null)
            {
                class1 = comboClassLevel1.SelectedItem.ToString() ?? "NULL";
                class1 = class1.Remove(0, 38);
            }
            if(comboClassLevel2.SelectedItem != null)
            {
                class2 = comboClassLevel2.SelectedItem.ToString() ?? "NULL";
                class2 = class2.Remove(0, 38);
            }
            if(comboClassLevel3.SelectedItem != null)
            {
                class3 = comboClassLevel3.SelectedItem.ToString() ?? "NULL";
                class3 = class3.Remove(0, 38);
            }


            classes[0] = class1;
            classes[1] = class2;
            classes[2] = class3;


            foreach (string s in classes)
            {
                switch (s)
                {
                    case "Druid":
                        Player.DruidLevels++;
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
