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
    /// Interaction logic for TabOverview.xaml
    /// </summary>
    public partial class TabOverview : UserControl
    {
        public TabOverview()
        {
            InitializeComponent();
        }

        private void txtOverviewStrengthScore_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtOverviewStrengthScore.Foreground = Brushes.Black;
            if (!int.TryParse(txtOverviewStrengthScore.Text, out Player.ScoreStr))
            {
                txtOverviewStrengthScore.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateStr();
            lblOverviewStrengthModifier.Content = PlayerMods.Str.ToString();
            lblOverviewStrengthSave.Content = PlayerMods.StrSave.ToString();
            lblOverviewAthleticsSave.Content = PlayerMods.Athletics.ToString();
        }

        private void txtOverviewDexterityScore_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtOverviewDexterityScore.Foreground = Brushes.Black;
            if (!int.TryParse(txtOverviewDexterityScore.Text, out Player.ScoreDex))
            {
                txtOverviewDexterityScore.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateDex();
            lblOverviewDexterityModifier.Content = PlayerMods.Dex.ToString();
        }

        private void txtOverviewConstitutionScore_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtOverviewConstitutionScore.Foreground = Brushes.Black;
            if (!int.TryParse(txtOverviewConstitutionScore.Text, out Player.ScoreCon))
            {
                txtOverviewConstitutionScore.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateCon();
            lblOverviewConstitutionModifier.Content = PlayerMods.Con.ToString();
        }

        private void txtOverviewIntelligenceScore_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtOverviewIntelligenceScore.Foreground = Brushes.Black;
            if (!int.TryParse(txtOverviewIntelligenceScore.Text, out Player.ScoreInt))
            {
                txtOverviewIntelligenceScore.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateInt();
            lblOverviewIntelligenceModifier.Content = PlayerMods.Int.ToString();
        }

        private void txtOverviewWisdomScore_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtOverviewWisdomScore.Foreground = Brushes.Black;
            if (!int.TryParse(txtOverviewWisdomScore.Text, out Player.ScoreWis))
            {
                txtOverviewWisdomScore.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateWis();
            lblOverviewWisdomModifier.Content = PlayerMods.Wis.ToString();
        }

        private void txtOverviewCharismaScore_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtOverviewCharismaScore.Foreground = Brushes.Black;
            if (!int.TryParse(txtOverviewCharismaScore.Text, out Player.ScoreCha))
            {
                txtOverviewCharismaScore.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateCha();
            lblOverviewCharismaModifier.Content = PlayerMods.Cha.ToString();
        }
    }
}
