using Avalonia.Controls;
using Avalonia.Media;
using DndCharacterApp.ViewModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MsBox.Avalonia;
using MsBox.Avalonia.Enums;
using DndCharacterApp.Data;
using DndCharacterApp.Objects.Player;

namespace DndCharacterApp.UI
{
    public partial class CharacterSheet : Window
    {
        CharacterSheetViewModel viewModel;
        public CharacterSheet()
        {
            InitializeComponent();
            DbConnectionFactory dbcf = new DbConnectionFactory("Data Source=players.db");
            dbcf.Initialize();
            viewModel = new CharacterSheetViewModel(dbcf);
            DataContext = viewModel;
        }

        private void btnExpPerLevel_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            ExpPerLevel epl = new ExpPerLevel();
            epl.Show(this);
        }

        private void menuSave_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            Player_NonStatic p = new Player_NonStatic();
            p.CharacterName = "BILLY";
            viewModel.WriteToDb(p).Wait();
        }
    }
}