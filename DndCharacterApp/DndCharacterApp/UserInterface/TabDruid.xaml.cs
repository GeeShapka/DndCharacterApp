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
    /// Interaction logic for TabDruid.xaml
    /// </summary>
    public partial class TabDruid : UserControl
    {
        public TabDruid()
        {
            InitializeComponent();
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
    }
}
