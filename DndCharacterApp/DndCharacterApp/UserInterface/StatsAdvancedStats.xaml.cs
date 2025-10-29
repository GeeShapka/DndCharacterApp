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

        //strength
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

        private void txtStatsStrengthSaveExtra_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtStatsStrengthSaveExtra.Foreground = Brushes.Black;
            if (!int.TryParse(txtStatsStrengthSaveExtra.Text, out PlayerMods.addStr))
            {
                txtStatsStrengthSaveExtra.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateStr();
        }

        //athletics
        private void radStatsAthleticsSaveProf_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.profAthletics = true;
            PlayerMods.expAthletics = false;
        }

        private void radStatsAthleticsSaveExp_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.expAthletics = true;
            PlayerMods.profAthletics = false;
        }
        private void txtStatsAthleticsSaveExtra_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtStatsAthleticsSaveExtra.Foreground = Brushes.Black;
            if (!int.TryParse(txtStatsAthleticsSaveExtra.Text, out PlayerMods.addAthletics))
            {
                txtStatsAthleticsSaveExtra.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateStr();
        }

        //dexterity
        private void radStatsDexteritySaveProf_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.profDex = true;
            PlayerMods.expDex = false;
        }

        private void radStatsDexteritySaveExp_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.expDex = true;
            PlayerMods.profDex = false;
        }

        private void txtStatsDexteritySaveExtra_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtStatsDexteritySaveExtra.Foreground = Brushes.Black;
            if (!int.TryParse(txtStatsDexteritySaveExtra.Text, out PlayerMods.addDex))
            {
                txtStatsDexteritySaveExtra.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateDex();
        }

        //acrobatics
        private void radStatsAcrobaticsSaveProf_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.profAcrobatics = true;
            PlayerMods.expAcrobatics = false;
        }

        private void radStatsAcrobaticsSaveExp_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.expAcrobatics = true;
            PlayerMods.profAcrobatics = false;
        }

        private void txtStatsAcrobaticsSaveExtra_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtStatsAcrobaticsSaveExtra.Foreground = Brushes.Black;
            if (!int.TryParse(txtStatsAcrobaticsSaveExtra.Text, out PlayerMods.addAcrobatics))
            {
                txtStatsAcrobaticsSaveExtra.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateDex();
        }

        //sleight of hand
        private void radStatsSleightOfHandSaveProf_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.profSleightOfHand = true;
            PlayerMods.expSleightOfHand = false;
        }

        private void radStatsSleightOfHandSaveExp_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.expSleightOfHand = true;
            PlayerMods.profSleightOfHand = false;
        }

        private void txtStatsSleightOfHandSaveExtra_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtStatsSleightOfHandSaveExtra.Foreground = Brushes.Black;
            if (!int.TryParse(txtStatsSleightOfHandSaveExtra.Text, out PlayerMods.addSleightOfHand))
            {
                txtStatsSleightOfHandSaveExtra.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateDex();
        }

        //stealth
        private void radStatsStealthSaveProf_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.profStealth = true;
            PlayerMods.expStealth = false;
        }

        private void radStatsStealthSaveExp_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.expStealth = true;
            PlayerMods.profStealth = false;
        }

        private void txtStatsStealthSaveExtra_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtStatsStealthSaveExtra.Foreground = Brushes.Black;
            if (!int.TryParse(txtStatsStealthSaveExtra.Text, out PlayerMods.addStealth))
            {
                txtStatsStealthSaveExtra.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateDex();
        }

        //constitution
        private void radStatsConstitutionSaveProf_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.profCon = true;
            PlayerMods.expCon = false;
        }

        private void radStatsConstitutionSaveExp_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.expCon = true;
            PlayerMods.profCon = false;
        }

        private void txtStatsConstitutionSaveExtra_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtStatsConstitutionSaveExtra.Foreground = Brushes.Black;
            if (!int.TryParse(txtStatsConstitutionSaveExtra.Text, out PlayerMods.addCon))
            {
                txtStatsConstitutionSaveExtra.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateCon();
        }

        //intelligence
        private void radStatsIntelligenceSaveProf_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.profInt = true;
            PlayerMods.expInt = false;
        }

        private void radStatsIntelligenceSaveExp_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.expInt = true;
            PlayerMods.profInt = false;
        }

        private void txtStatsIntelligenceSaveExtra_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtStatsIntelligenceSaveExtra.Foreground = Brushes.Black;
            if (!int.TryParse(txtStatsIntelligenceSaveExtra.Text, out PlayerMods.addInt))
            {
                txtStatsIntelligenceSaveExtra.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateInt();
        }

        //arcana
        private void radStatsArcanaSaveProf_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.profArcana = true;
            PlayerMods.expArcana = false;
        }

        private void radStatsArcanaSaveExp_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.expArcana = true;
            PlayerMods.profArcana = false;
        }

        private void txtStatsArcanaSaveExtra_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtStatsArcanaSaveExtra.Foreground = Brushes.Black;
            if (!int.TryParse(txtStatsArcanaSaveExtra.Text, out PlayerMods.addArcana))
            {
                txtStatsArcanaSaveExtra.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateInt();
        }

        //history
        private void radStatsHistorySaveProf_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.profHistory = true;
            PlayerMods.expHistory = false;
        }

        private void radStatsHistorySaveExp_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.expHistory = true;
            PlayerMods.profHistory = false;
        }

        private void txtStatsHistorySaveExtra_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtStatsHistorySaveExtra.Foreground = Brushes.Black;
            if (!int.TryParse(txtStatsHistorySaveExtra.Text, out PlayerMods.addHistory))
            {
                txtStatsHistorySaveExtra.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateInt();
        }

        //investigation
        private void radStatsInvestigationSaveProf_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.profInvestigation = true;
            PlayerMods.expInvestigation = false;
        }

        private void radStatsInvestigationSaveExp_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.expInvestigation = true;
            PlayerMods.profInvestigation = false;
        }

        private void txtStatsInvestigationSaveExtra_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtStatsInvestigationSaveExtra.Foreground = Brushes.Black;
            if (!int.TryParse(txtStatsInvestigationSaveExtra.Text, out PlayerMods.addInvestigation))
            {
                txtStatsInvestigationSaveExtra.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateInt();
        }

        //nature
        private void radStatsNatureSaveProf_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.profNature = true;
            PlayerMods.expNature = false;
        }

        private void radStatsNatureSaveExp_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.expNature = true;
            PlayerMods.profNature = false;
        }

        private void txtStatsNatureSaveExtra_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtStatsNatureSaveExtra.Foreground = Brushes.Black;
            if (!int.TryParse(txtStatsNatureSaveExtra.Text, out PlayerMods.addNature))
            {
                txtStatsNatureSaveExtra.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateInt();
        }

        //religion
        private void radStatsReligionSaveProf_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.profReligion = true;
            PlayerMods.expReligion = false;
        }

        private void radStatsReligionSaveExp_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.expReligion = true;
            PlayerMods.profReligion = false;
        }

        private void txtStatsReligionSaveExtra_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtStatsReligionSaveExtra.Foreground = Brushes.Black;
            if (!int.TryParse(txtStatsReligionSaveExtra.Text, out PlayerMods.addReligion))
            {
                txtStatsReligionSaveExtra.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateInt();
        }

        //wisdom
        private void radStatsWisdomSaveProf_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.profWis = true;
            PlayerMods.expWis = false;
        }

        private void radStatsWisdomSaveExp_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.expWis = true;
            PlayerMods.profWis = false;
        }

        private void txtStatsWisdomSaveExtra_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtStatsWisdomSaveExtra.Foreground = Brushes.Black;
            if (!int.TryParse(txtStatsWisdomSaveExtra.Text, out PlayerMods.addWis))
            {
                txtStatsWisdomSaveExtra.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateWis();
        }

        //animal handling
        private void radStatsAnimalHandlingSaveProf_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.profAnimalHandling = true;
            PlayerMods.expAnimalHandling = false;
        }

        private void radStatsAnimalHandlingSaveExp_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.expAnimalHandling = true;
            PlayerMods.profAnimalHandling = false;
        }

        private void txtStatsAnimalHandlingSaveExtra_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtStatsAnimalHandlingSaveExtra.Foreground = Brushes.Black;
            if (!int.TryParse(txtStatsAnimalHandlingSaveExtra.Text, out PlayerMods.addAnimalHandling))
            {
                txtStatsAnimalHandlingSaveExtra.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateWis();
        }

        //insight
        private void radStatsInsightSaveProf_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.profInsight = true;
            PlayerMods.expInsight = false;
        }

        private void radStatsInsightSaveExp_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.expInsight = true;
            PlayerMods.profInsight = false;
        }

        private void txtStatsInsightSaveExtra_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtStatsInsightSaveExtra.Foreground = Brushes.Black;
            if (!int.TryParse(txtStatsInsightSaveExtra.Text, out PlayerMods.addInsight))
            {
                txtStatsInsightSaveExtra.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateWis();
        }

        //medicine
        private void radStatsMedicineSaveProf_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.profMedicine = true;
            PlayerMods.expMedicine = false;
        }

        private void radStatsMedicineSaveExp_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.expMedicine = true;
            PlayerMods.profMedicine = false;
        }

        private void txtStatsMedicineSaveExtra_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtStatsMedicineSaveExtra.Foreground = Brushes.Black;
            if (!int.TryParse(txtStatsMedicineSaveExtra.Text, out PlayerMods.addMedicine))
            {
                txtStatsMedicineSaveExtra.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateWis();
        }

        //perception
        private void radStatsPerceptionSaveProf_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.profPerception = true;
            PlayerMods.expPerception = false;
        }

        private void radStatsPerceptionSaveExp_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.expPerception = true;
            PlayerMods.profPerception = false;
        }

        private void txtStatsPerceptionSaveExtra_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtStatsPerceptionSaveExtra.Foreground = Brushes.Black;
            if (!int.TryParse(txtStatsPerceptionSaveExtra.Text, out PlayerMods.addPerception))
            {
                txtStatsPerceptionSaveExtra.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateWis();
        }

        //survival
        private void radStatsSurvivalSaveProf_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.profSurvival = true;
            PlayerMods.expSurvival = false;
        }

        private void radStatsSurvivalSaveExp_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.expSurvival = true;
            PlayerMods.profSurvival = false;
        }

        private void txtStatsSurvivalSaveExtra_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtStatsSurvivalSaveExtra.Foreground = Brushes.Black;
            if (!int.TryParse(txtStatsSurvivalSaveExtra.Text, out PlayerMods.addSurvival))
            {
                txtStatsSurvivalSaveExtra.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateWis();
        }

        //charisma
        private void radStatsCharismaSaveProf_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.profCha = true;
            PlayerMods.expCha = false;
        }

        private void radStatsCharismaSaveExp_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.expCha = true;
            PlayerMods.profCha = false;
        }

        private void txtStatsCharismaSaveExtra_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtStatsCharismaSaveExtra.Foreground = Brushes.Black;
            if (!int.TryParse(txtStatsCharismaSaveExtra.Text, out PlayerMods.addCha))
            {
                txtStatsCharismaSaveExtra.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateCha();
        }

        //deception
        private void radStatsDeceptionSaveProf_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.profDeception = true;
            PlayerMods.expDeception = false;
        }

        private void radStatsDeceptionSaveExp_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.expDeception = true;
            PlayerMods.profDeception = false;
        }

        private void txtStatsDeceptionSaveExtra_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtStatsDeceptionSaveExtra.Foreground = Brushes.Black;
            if (!int.TryParse(txtStatsDeceptionSaveExtra.Text, out PlayerMods.addDeception))
            {
                txtStatsDeceptionSaveExtra.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateCha();
        }

        //intimidation
        private void radStatsIntimidationSaveProf_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.profIntimidation = true;
            PlayerMods.expIntimidation = false;
        }

        private void radStatsIntimidationSaveExp_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.expIntimidation = true;
            PlayerMods.profIntimidation = false;
        }

        private void txtStatsIntimidationSaveExtra_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtStatsIntimidationSaveExtra.Foreground = Brushes.Black;
            if (!int.TryParse(txtStatsIntimidationSaveExtra.Text, out PlayerMods.addIntimidation))
            {
                txtStatsIntimidationSaveExtra.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateCha();
        }

        //performance
        private void radStatsPerformanceSaveProf_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.profPerformance = true;
            PlayerMods.expPerformance = false;
        }

        private void radStatsPerformanceSaveExp_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.expPerformance = true;
            PlayerMods.profPerformance = false;
        }

        private void txtStatsPerformanceSaveExtra_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtStatsPerformanceSaveExtra.Foreground = Brushes.Black;
            if (!int.TryParse(txtStatsPerformanceSaveExtra.Text, out PlayerMods.addPerformance))
            {
                txtStatsPerformanceSaveExtra.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateCha();
        }

        //persuasion
        private void radStatsPersuasionSaveProf_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.profPersuasion = true;
            PlayerMods.expPersuasion = false;
        }

        private void radStatsPersuasionSaveExp_Click(object sender, RoutedEventArgs e)
        {
            PlayerMods.expPersuasion = true;
            PlayerMods.profPersuasion = false;
        }

        private void txtStatsPersuasionSaveExtra_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtStatsPersuasionSaveExtra.Foreground = Brushes.Black;
            if (!int.TryParse(txtStatsPersuasionSaveExtra.Text, out PlayerMods.addPersuasion))
            {
                txtStatsPersuasionSaveExtra.Foreground = Brushes.Red;
                return;
            }
            Player.UpdateCha();
        }
    }//end of class
}
