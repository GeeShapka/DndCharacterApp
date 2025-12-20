using Avalonia.Controls;

namespace DndCharacterApp.UI
{
    public partial class CharacterSheet : Window
    {
        public CharacterSheet()
        {
            InitializeComponent();
        }

        private void btnExpPerLevel_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            ExpPerLevel epl = new ExpPerLevel();
            epl.Show();
        }
    }
}