using Avalonia.Controls;
using Avalonia.Media;
using DndCharacterApp.ViewModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MsBox.Avalonia;
using MsBox.Avalonia.Enums;

namespace DndCharacterApp.UI
{
    public partial class CharacterSheet : Window
    {
        public CharacterSheet()
        {
            InitializeComponent();
            CharacterSheetViewModel viewModel = new CharacterSheetViewModel();
            DataContext = viewModel;
        }

        private void btnExpPerLevel_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            ExpPerLevel epl = new ExpPerLevel();
            epl.Show(this);
        }
    }
}