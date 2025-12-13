using DndCharacterApp.Objects.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
	/// Interaction logic for TabDruid.xaml
	/// </summary>
	public partial class TabDruid : UserControl
	{
		public TabDruid()
		{
			InitializeComponent();
			Player.StaticPropertyChanged += UpdateDruidTab;
		}

		public void UpdateDruidTab(object? sender, PropertyChangedEventArgs e)
		{
            if (e.PropertyName == "DruidLevels")
            {
				SetSpellSlots();

                // reset all
                stkDruid1st.Background = Brushes.LightGray;
                stkDruid2nd.Background = Brushes.LightGray;
                stkDruid3rd.Background = Brushes.LightGray;
                stkDruid4th.Background = Brushes.LightGray;
                stkDruid5th.Background = Brushes.LightGray;
                stkDruid6th.Background = Brushes.LightGray;
                stkDruid7th.Background = Brushes.LightGray;
                stkDruid8th.Background = Brushes.LightGray;
                stkDruid9th.Background = Brushes.LightGray;
                stkDruid10th.Background = Brushes.LightGray;
                stkDruid11th.Background = Brushes.LightGray;
                stkDruid12th.Background = Brushes.LightGray;
                stkDruid13th.Background = Brushes.LightGray;
                stkDruid14th.Background = Brushes.LightGray;
                stkDruid15th.Background = Brushes.LightGray;
                stkDruid16th.Background = Brushes.LightGray;
                stkDruid17th.Background = Brushes.LightGray;
                stkDruid18th.Background = Brushes.LightGray;
                stkDruid19th.Background = Brushes.LightGray;
                stkDruid20th.Background = Brushes.LightGray;

                switch (Player.DruidLevels)
                {
                    case 20: stkDruid20th.Background = Brushes.Transparent; goto case 19;
                    case 19: stkDruid19th.Background = Brushes.Transparent; goto case 18;
                    case 18: stkDruid18th.Background = Brushes.Transparent; goto case 17;
                    case 17: stkDruid17th.Background = Brushes.Transparent; goto case 16;
                    case 16: stkDruid16th.Background = Brushes.Transparent; goto case 15;
                    case 15: stkDruid15th.Background = Brushes.Transparent; goto case 14;
                    case 14: stkDruid14th.Background = Brushes.Transparent; goto case 13;
                    case 13: stkDruid13th.Background = Brushes.Transparent; goto case 12;
                    case 12: stkDruid12th.Background = Brushes.Transparent; goto case 11;
                    case 11: stkDruid11th.Background = Brushes.Transparent; goto case 10;
                    case 10: stkDruid10th.Background = Brushes.Transparent; goto case 9;
                    case 9: stkDruid9th.Background = Brushes.Transparent; goto case 8;
                    case 8: stkDruid8th.Background = Brushes.Transparent; goto case 7;
                    case 7: stkDruid7th.Background = Brushes.Transparent; goto case 6;
                    case 6: stkDruid6th.Background = Brushes.Transparent; goto case 5;
                    case 5: stkDruid5th.Background = Brushes.Transparent; goto case 4;
                    case 4: stkDruid4th.Background = Brushes.Transparent; goto case 3;
                    case 3: stkDruid3rd.Background = Brushes.Transparent; goto case 2;
                    case 2: stkDruid2nd.Background = Brushes.Transparent; goto case 1;
                    case 1: stkDruid1st.Background = Brushes.Transparent; break;
                    default:
                        break;
                }
            }

            else if (e.PropertyName == "DruidSubclass")
			{
				//make sure all subclass buttons are hidden first
				btnDruidSporesCircleSpells.Visibility = Visibility.Hidden;
				btnDruidSporesHaloOfSpores.Visibility = Visibility.Hidden;
				btnDruidSporesSymbioticEntity.Visibility = Visibility.Hidden;



				string subclass = Player.DruidSubclass;
				switch (subclass)
				{
					case "Dreams":
						break;
					case "Land":
						break;
					case "Moon":
						break;
					case "Shepherd":
						break;
					case "Spores":
						comboDruidSubClass.SelectedIndex = 4;
						btnDruidSporesCircleSpells.Visibility = Visibility.Visible;
						btnDruidSporesHaloOfSpores.Visibility = Visibility.Visible;
						btnDruidSporesSymbioticEntity.Visibility = Visibility.Visible;
						break;
					case "Stars":
						break;
					case "Wildfire":
						break;
					default:
						comboDruidSubClass.SelectedIndex = -1;
						break;
				}

			}
		}//end of UpdateDruidTab

		private void SetSpellSlots()
		{
			switch (Player.DruidLevels)
			{
				case 1:
					lblDruidCantrip.Content = "2";
					lblDruid1stSS.Content = "2";
					break;
				case 2:
					lblDruidCantrip.Content = "2";
					lblDruid1stSS.Content = "3";
					break;
				case 3:
					lblDruidCantrip.Content = "2";
					lblDruid1stSS.Content = "4";
					lblDruid2ndSS.Content = "2";
					break;
				case 4:
					lblDruidCantrip.Content = "3";
					lblDruid1stSS.Content = "4";
					lblDruid2ndSS.Content = "3";
					break;
				case 5:
					lblDruidCantrip.Content = "3";
					lblDruid1stSS.Content = "4";
					lblDruid2ndSS.Content = "3";
					lblDruid3rdSS.Content = "2";
					break;
				case 6:
					lblDruidCantrip.Content = "3";
					lblDruid1stSS.Content = "4";
					lblDruid2ndSS.Content = "3";
					lblDruid3rdSS.Content = "3";
					break;
				case 7:
					lblDruidCantrip.Content = "3";
					lblDruid1stSS.Content = "4";
					lblDruid2ndSS.Content = "3";
					lblDruid3rdSS.Content = "3";
					lblDruid4thSS.Content = "1";
					break;
				case 8:
					lblDruidCantrip.Content = "3";
					lblDruid1stSS.Content = "4";
					lblDruid2ndSS.Content = "3";
					lblDruid3rdSS.Content = "3";
					lblDruid4thSS.Content = "2";
					break;
				case 9:
					lblDruidCantrip.Content = "3";
					lblDruid1stSS.Content = "4";
					lblDruid2ndSS.Content = "3";
					lblDruid3rdSS.Content = "3";
					lblDruid4thSS.Content = "3";
					lblDruid5thSS.Content = "1";
					break;
				case 10:
					lblDruidCantrip.Content = "4";
					lblDruid1stSS.Content = "4";
					lblDruid2ndSS.Content = "3";
					lblDruid3rdSS.Content = "3";
					lblDruid4thSS.Content = "3";
					lblDruid5thSS.Content = "2";
					break;
				case 11:
					lblDruidCantrip.Content = "4";
					lblDruid1stSS.Content = "4";
					lblDruid2ndSS.Content = "3";
					lblDruid3rdSS.Content = "3";
					lblDruid4thSS.Content = "3";
					lblDruid5thSS.Content = "2";
					lblDruid6thSS.Content = "1";
					break;
				case 12:
					lblDruidCantrip.Content = "4";
					lblDruid1stSS.Content = "4";
					lblDruid2ndSS.Content = "3";
					lblDruid3rdSS.Content = "3";
					lblDruid4thSS.Content = "3";
					lblDruid5thSS.Content = "2";
					lblDruid6thSS.Content = "1";
					break;
				case 13:
					lblDruidCantrip.Content = "4";
					lblDruid1stSS.Content = "4";
					lblDruid2ndSS.Content = "3";
					lblDruid3rdSS.Content = "3";
					lblDruid4thSS.Content = "3";
					lblDruid5thSS.Content = "2";
					lblDruid6thSS.Content = "1";
					lblDruid7thSS.Content = "1";
					break;
				case 14:
					lblDruidCantrip.Content = "4";
					lblDruid1stSS.Content = "4";
					lblDruid2ndSS.Content = "3";
					lblDruid3rdSS.Content = "3";
					lblDruid4thSS.Content = "3";
					lblDruid5thSS.Content = "2";
					lblDruid6thSS.Content = "1";
					lblDruid7thSS.Content = "1";
					break;
				case 15:
					lblDruidCantrip.Content = "4";
					lblDruid1stSS.Content = "4";
					lblDruid2ndSS.Content = "3";
					lblDruid3rdSS.Content = "3";
					lblDruid4thSS.Content = "3";
					lblDruid5thSS.Content = "2";
					lblDruid6thSS.Content = "1";
					lblDruid7thSS.Content = "1";
					lblDruid8thSS.Content = "1";
					break;
				case 16:
					lblDruidCantrip.Content = "4";
					lblDruid1stSS.Content = "4";
					lblDruid2ndSS.Content = "3";
					lblDruid3rdSS.Content = "3";
					lblDruid4thSS.Content = "3";
					lblDruid5thSS.Content = "2";
					lblDruid6thSS.Content = "1";
					lblDruid7thSS.Content = "1";
					lblDruid8thSS.Content = "1";
					break;
				case 17:
					lblDruidCantrip.Content = "4";
					lblDruid1stSS.Content = "4";
					lblDruid2ndSS.Content = "3";
					lblDruid3rdSS.Content = "3";
					lblDruid4thSS.Content = "3";
					lblDruid5thSS.Content = "2";
					lblDruid6thSS.Content = "1";
					lblDruid7thSS.Content = "1";
					lblDruid8thSS.Content = "1";
					lblDruid9thSS.Content = "1";
					break;
				case 18:
					lblDruidCantrip.Content = "4";
					lblDruid1stSS.Content = "4";
					lblDruid2ndSS.Content = "3";
					lblDruid3rdSS.Content = "3";
					lblDruid4thSS.Content = "3";
					lblDruid5thSS.Content = "3";
					lblDruid6thSS.Content = "1";
					lblDruid7thSS.Content = "1";
					lblDruid8thSS.Content = "1";
					lblDruid9thSS.Content = "1";
					break;
				case 19:
					lblDruidCantrip.Content = "4";
					lblDruid1stSS.Content = "4";
					lblDruid2ndSS.Content = "3";
					lblDruid3rdSS.Content = "3";
					lblDruid4thSS.Content = "3";
					lblDruid5thSS.Content = "3";
					lblDruid6thSS.Content = "2";
					lblDruid7thSS.Content = "1";
					lblDruid8thSS.Content = "1";
					lblDruid9thSS.Content = "1";
					break;
				case 20:
					lblDruidCantrip.Content = "4";
					lblDruid1stSS.Content = "4";
					lblDruid2ndSS.Content = "3";
					lblDruid3rdSS.Content = "3";
					lblDruid4thSS.Content = "3";
					lblDruid5thSS.Content = "3";
					lblDruid6thSS.Content = "2";
					lblDruid7thSS.Content = "2";
					lblDruid8thSS.Content = "1";
					lblDruid9thSS.Content = "1";
					break;
			}
		}

		private void btnDruidDruidic_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("You know Druidic, the secret language of druids. You can speak the language and use it to leave hidden messages. You and others who know this language automatically spot such a message. Others spot the message's presence with a successful DC 15 Wisdom (Perception) check but can't decipher it without magic.");
		}

		private void btnDruidSpellcasting_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Drawing on the divine essence of nature itself, you can cast spells to shape that essence to your will.\r\n\r\nCantrips\r\nAt 1st level, you know two cantrips of your choice from the druid spell list. You learn additional druid cantrips of your choice at higher levels, as shown in the Cantrips Known column of the Druid table.\r\n\r\nPreparing and Casting Spells\r\nThe Druid table shows how many spell slots you have to cast your druid spells of 1st level and higher. To cast one of these druid spells, you must expend a slot of the spell's level or higher. You regain all expended spell slots when you finish a long rest.\r\n\r\nYou prepare the list of druid spells that are available for you to cast, choosing from the druid spell list. When you do so, choose a number of druid spells equal to your Wisdom modifier + your Druid level (minimum of one spell). The spells must be of a level for which you have spell slots.\r\n\r\nFor example, if you are a 3rd-level druid, you have four 1st-level and two 2nd-level spell slots. With a Wisdom of 16, your list of prepared spells can include six spells of 1st or 2nd level, in any combination. If you prepare the 1st-level spell Cure Wounds, you can cast it using a 1st-level or 2nd-level slot. Casting the spell doesn't remove it from your list of prepared spells.\r\nYou can also change your list of prepared spells when you finish a long rest. Preparing a new list of druid spells requires time spent in prayer and meditation: at least 1 minute per spell level for each spell on your list.\r\n\r\nSpellcasting Ability\r\nWisdom is your spellcasting ability for your druid spells, since your magic draws upon your devotion and attunement to nature. You use your Wisdom whenever a spell refers to your spellcasting ability. In addition, you use your Wisdom modifier when setting the saving throw DC for a druid spell you cast and when making an attack roll with one.\r\n\r\nSpell save DC = 8 + your proficiency bonus + your Wisdom modifier\r\n\r\nSpell attack modifier = your proficiency bonus + your Wisdom modifier\r\n\r\nRitual Casting\r\nYou can cast a druid spell as a ritual if that spell has the ritual tag and you have the spell prepared.\r\n\r\nSpellcasting Focus\r\nYou can use a druidic focus as a spellcasting focus for your druid spells.");
		}

		private void btnDruidWildShape_Click(object sender, RoutedEventArgs e)
		{
			DruidWildShape dws = new DruidWildShape();
			dws.Show();
		}

		private void btnDruidWildCompanion_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("At 2nd level, you gain the ability to summon a spirit that assumes an animal form: as an action, you can expend a use of your Wild Shape feature to cast the Find Familiar spell, without material components.\r\n\r\nWhen you cast the spell in this way, the familiar is a fey instead of a beast, and the familiar disappears after a number of hours equal to half your druid level.");
		}

		private void btnDruidAsi_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("When you reach 4th level, and again at 8th, 12th, 16th, and 19th level, you can increase one ability score of your choice by 2, or you can increase two ability scores of your choice by 1. As normal, you can't increase an ability score above 20 using this feature.");
		}

		private void btnDruidCantripVersatility_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Whenever you reach a level in this class that grants the Ability Score Improvement feature, you can replace one cantrip you learned from this class's Spellcasting feature with another cantrip from the druid spell list.");
		}

		private void btnDruidTimelessBody_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Starting at 18th level, the primal magic that you wield causes you to age more slowly. For every 10 years that pass, your body ages only 1 year.");
		}

		private void btnDruidBeastSpells_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Beginning at 18th level, you can cast many of your druid spells in any shape you assume using Wild Shape. You can perform the somatic and verbal components of a druid spell while in a beast shape, but you aren't able to provide material components");
		}

		private void btnDruidArchdruid_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("At 20th level, you can use your Wild Shape an unlimited number of times.\r\n\r\nAdditionally, you can ignore the verbal and somatic components of your druid spells, as well as any material components that lack a cost and aren't consumed by a spell. You gain this benefit in both your normal shape and your beast shape from Wild Shape.");
		}

		private void comboDruidSubClass_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if(comboDruidSubClass.SelectedItem != null)
            {
                string theSubClass = comboDruidSubClass.SelectedItem.ToString() ?? "NULL";
                theSubClass = theSubClass.Remove(0, 38);
                Player.DruidSubclass = theSubClass;
            }
		}


		//spore druid
		private void btnDruidSporesCircleSpells_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnDruidSporesHaloOfSpores_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Starting at 2nd level, you are surrounded by invisible, necrotic spores that are harmless until you unleash them on a creature nearby. When a creature you can see moves into a space within 10 feet of you or starts its turn there, you can use your reaction to deal 1d4 necrotic damage to that creature unless it succeeds on a Constitution saving throw against your spell save DC. The necrotic damage increases to 1d6 at 6th level, 1d8 at 10th level, and 1d10 at 14th level.");
		}

		private void btnDruidSporesSymbioticEntity_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Also at 2nd level, you gain the ability to channel magic into your spores. As an action, you can expend a use of your Wild Shape feature to awaken those spores, rather than transforming into a beast form, and you gain 4 temporary hit points for each level you have in this class. While this feature is active, you gain the following benefits:\r\n\t- When you deal your Halo of Spores damage, roll the damage\n\t die a second time and add it to the total.\r\n\t- Your melee weapon attacks deal an extra 1d6 necrotic damage\n\t to any target they hit.\r\n\r\nThese benefits last for 10 minutes, until you lose all these temporary hit points. or until you use your Wild Shape again.");
		}
	}
}
