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
	public partial class TabOverview : UserControl//change all lbl.text = player.stat to events maybe?
	{
		public TabOverview()
		{
			InitializeComponent();
			txtOverviewPlayerPb.Text = Player.Prof.ToString();
		}

		/// <summary>
		/// updates the overview tab
		/// </summary>
		private void updateOverviewTab()//change to events in the future???
        {
            //update Player
            Player.UpdateAll();

            //main atribute stats and stuff
            txtOverviewPlayerHp.Text = Player.Hp.ToString();
			txtOverviewPlayerTempHp.Text = Player.TempHp.ToString();
			txtOverviewPlayerAc.Text = Player.ArmorClass.ToString();
			txtOverviewPlayerInitiative.Text = PlayerMods.Dex.ToString();
			txtOverviewPlayerSpeed.Text = Player.Speed.ToString();
			txtOverviewPlayerPb.Text = Player.Prof.ToString();

			//update stats
			lblOverviewStrengthModifier.Content = PlayerMods.Str.ToString();
			lblOverviewStrengthSave.Content = PlayerMods.StrSave.ToString();
			lblOverviewAthleticsSave.Content = PlayerMods.Athletics.ToString();
			lblOverviewDexterityModifier.Content = PlayerMods.Dex.ToString();
			lblOverviewDexteritySave.Content = PlayerMods.DexSave.ToString();
			lblOverviewAcrobaticsSave.Content = PlayerMods.Acrobatics.ToString();
			lblOverviewSleightOfHandSave.Content = PlayerMods.SleightOfHand.ToString();
			lblOverviewStealthSave.Content = PlayerMods.Stealth.ToString();
			lblOverviewConstitutionModifier.Content = PlayerMods.Con.ToString();
			lblOverviewConstitutionSave.Content = PlayerMods.ConSave.ToString();
			lblOverviewIntelligenceModifier.Content = PlayerMods.Int.ToString();
			lblOverviewIntelligenceSave.Content = PlayerMods.IntSave.ToString();
			lblOverviewArcanaSave.Content = PlayerMods.Arcana.ToString();
			lblOverviewHistorySave.Content = PlayerMods.History.ToString();
			lblOverviewInvestigationSave.Content = PlayerMods.Investigation.ToString();
			lblOverviewNatureSave.Content = PlayerMods.Nature.ToString();
			lblOverviewReligionSave.Content = PlayerMods.Religion.ToString();
			lblOverviewWisdomModifier.Content = PlayerMods.Wis.ToString();
			lblOverviewWisdomSave.Content = PlayerMods.WisSave.ToString();
			lblOverviewAnimalHandlingSave.Content = PlayerMods.AnimalHandling.ToString();
			lblOverviewInsightSave.Content = PlayerMods.Insight.ToString();
			lblOverviewMedicineSave.Content = PlayerMods.Medicine.ToString();
			lblOverviewPerceptionSave.Content = PlayerMods.Perception.ToString();
			lblOverviewSurvivalSave.Content = PlayerMods.Survival.ToString();
			lblOverviewCharismaModifier.Content = PlayerMods.Cha.ToString();
			lblOverviewCharismaSave.Content = PlayerMods.ChaSave.ToString();
			lblOverviewDeceptionSave.Content = PlayerMods.Deception.ToString();
			lblOverviewIntimidationSave.Content = PlayerMods.Intimidation.ToString();
			lblOverviewPerformanceSave.Content = PlayerMods.Performance.ToString();
			lblOverviewPersuasionSave.Content = PlayerMods.Persuasion.ToString();
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
			lblOverviewDexteritySave.Content = PlayerMods.DexSave.ToString();
			lblOverviewAcrobaticsSave.Content = PlayerMods.Acrobatics.ToString();
			lblOverviewSleightOfHandSave.Content = PlayerMods.SleightOfHand.ToString();
			lblOverviewStealthSave.Content = PlayerMods.Stealth.ToString();
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
			lblOverviewConstitutionSave.Content = PlayerMods.ConSave.ToString();
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
			lblOverviewIntelligenceSave.Content = PlayerMods.IntSave.ToString();
			lblOverviewArcanaSave.Content = PlayerMods.Arcana.ToString();
			lblOverviewHistorySave.Content = PlayerMods.History.ToString();
			lblOverviewInvestigationSave.Content = PlayerMods.Investigation.ToString();
			lblOverviewNatureSave.Content = PlayerMods.Nature.ToString();
			lblOverviewReligionSave.Content = PlayerMods.Religion.ToString();
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
			lblOverviewWisdomSave.Content = PlayerMods.WisSave.ToString();
			lblOverviewAnimalHandlingSave.Content = PlayerMods.AnimalHandling.ToString();
			lblOverviewInsightSave.Content = PlayerMods.Insight.ToString();
			lblOverviewMedicineSave.Content = PlayerMods.Medicine.ToString();
			lblOverviewPerceptionSave.Content = PlayerMods.Perception.ToString();
			lblOverviewSurvivalSave.Content = PlayerMods.Survival.ToString();
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
			lblOverviewCharismaSave.Content = PlayerMods.ChaSave.ToString();
			lblOverviewDeceptionSave.Content= PlayerMods.Deception.ToString();
			lblOverviewIntimidationSave.Content = PlayerMods.Intimidation.ToString();
			lblOverviewPerformanceSave.Content = PlayerMods.Performance.ToString();
			lblOverviewPersuasionSave.Content = PlayerMods.Persuasion.ToString();
		}


		//update pb
		private void txtOverviewPlayerPb_TextChanged(object sender, TextChangedEventArgs e)
		{
			txtOverviewPlayerPb.Foreground = Brushes.Black;
			if (!int.TryParse(txtOverviewPlayerPb.Text, out Player.Prof))
			{
				txtOverviewPlayerPb.Foreground = Brushes.Red;
				return;
			}
			Player.UpdateAll();
			updateOverviewTab();
		}

		/// <summary>
		/// update overview tab with latest data when loaded
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void UserControl_Loaded(object sender, RoutedEventArgs e)
		{
			updateOverviewTab();
		}

		/// <summary>
		/// sets the players hp
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtOverviewPlayerHp_TextChanged(object sender, TextChangedEventArgs e)
		{
			txtOverviewPlayerHp.Foreground = Brushes.Black;
			if (!int.TryParse(txtOverviewPlayerHp.Text, out Player.Hp))
			{
				txtOverviewPlayerHp.Foreground = Brushes.Red;
				return;
            }
            Player.UpdateTotalHp();
        }

		/// <summary>
		/// sets the players temp hp
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtOverviewPlayerTempHp_TextChanged(object sender, TextChangedEventArgs e)
		{
			txtOverviewPlayerTempHp.Foreground = Brushes.Black;
			if (!int.TryParse(txtOverviewPlayerTempHp.Text, out Player.TempHp))
			{
				txtOverviewPlayerTempHp.Foreground = Brushes.Red;
				return;
			}
			Player.UpdateTotalHp();
		}

		/// <summary>
		/// sets the player ac
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void txtOverviewPlayerAc_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtOverviewPlayerAc.Foreground = Brushes.Black;
			int temp;
            if (!int.TryParse(txtOverviewPlayerAc.Text, out temp))
            {
                txtOverviewPlayerAc.Foreground = Brushes.Red;
                return;
            }
			Player.ArmorClass = temp;
        }
    }
}
