using DndCharacterApp.Objects.Player;
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

namespace DndCharacterApp.UserInterface
{
    /// <summary>
    /// Interaction logic for StatsAdvancedStats.xaml
    /// </summary>
    public partial class StatsAdvancedStats : UserControl
    {
        public StatsAdvancedStats()
        {
            InitializeComponent();
        }

        private void radStatsStrengthSaveProf_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.profStr = true;
            PlayerMods.expStr = false;
        }

        private void radStatsStrengthSaveExp_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.expStr = true;
            PlayerMods.profStr = false;
        }
    }
}
