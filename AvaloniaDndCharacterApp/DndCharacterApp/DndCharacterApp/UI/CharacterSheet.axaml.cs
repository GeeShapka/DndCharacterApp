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
            p.CharacterName = txtCharacterName.Text ?? string.Empty;
            viewModel.WriteToDb(p).Wait();
        }




        //attribute updates
        private void txtCharacterName_TextChanged(object? sender, TextChangedEventArgs e)
        {
            txtCharacterName.Foreground = Brushes.Black;
            if (!viewModel.UpdateCurrentPlayer(txtCharacterName.Text, "CharacterName"))
            {
                txtCharacterName.Foreground = Brushes.Red;
            }
        }

        private void txtClass_TextChanged(object? sender, TextChangedEventArgs e)
        {

        }

        private void txtBackground_TextChanged(object? sender, TextChangedEventArgs e)
        {
        }

        private void txtPlayerName_TextChanged(object? sender, TextChangedEventArgs e)
        {
        }

        private void txtRace_TextChanged(object? sender, TextChangedEventArgs e)
        {
        }

        private void txtAlignment_TextChanged(object? sender, TextChangedEventArgs e)
        {
        }

        private void txtExperiencePoints_TextChanged(object? sender, TextChangedEventArgs e)
        {
            txtExperiencePoints.Foreground = Brushes.Black;
            int xp;
            if (!int.TryParse(txtExperiencePoints.Text, out xp))
            {
                txtExperiencePoints.Foreground = Brushes.Red;
            }
            else if (!viewModel.UpdateCurrentPlayer(xp, "Xp"))
            {
                txtExperiencePoints.Foreground = Brushes.Red;
            }
        }

        private void txtTempHp_TextChanged(object? sender, TextChangedEventArgs e)
        {
            txtTempHp.Foreground = Brushes.Black;
            int tempHp;
            if (!int.TryParse(txtTempHp.Text, out tempHp))
            {
                txtTempHp.Foreground = Brushes.Red;
            }
            else if (!viewModel.UpdateCurrentPlayer(tempHp, "TempHp"))
            {
                txtTempHp.Foreground = Brushes.Red;
            }
        }

        private void txtMaxHp_TextChanged(object? sender, TextChangedEventArgs e)
        {
            txtMaxHp.Foreground = Brushes.Black;
            int maxHp;
            if(!int.TryParse(txtMaxHp.Text, out maxHp))
            {
                txtMaxHp.Foreground = Brushes.Red;
            }
            else if (!viewModel.UpdateCurrentPlayer(maxHp, "MaxHp"))
            {
                txtMaxHp.Foreground = Brushes.Red;
            }
        }

        private void txtCurrentHp_TextChanged(object? sender, TextChangedEventArgs e)
        {
            txtCurrentHp.Foreground = Brushes.Black;
            int currentHp;
            if (!int.TryParse(txtCurrentHp.Text, out currentHp))
            {
                txtCurrentHp.Foreground = Brushes.Red;
            }
            else if (!viewModel.UpdateCurrentPlayer(currentHp, "CurrentHp"))
            {
                txtCurrentHp.Foreground = Brushes.Red;
            }
        }

        private void txtBoons_TextChanged(object? sender, TextChangedEventArgs e)
        {
        }

        private void txtInitiative_TextChanged(object? sender, TextChangedEventArgs e)
        {
        }

        private void txtHitDice_TextChanged(object? sender, TextChangedEventArgs e)
        {
        }

        private void txtArmorClass_TextChanged(object? sender, TextChangedEventArgs e)
        {
            txtArmorClass.Foreground = Brushes.Black;
            int armorClass;
            if (!int.TryParse(txtArmorClass.Text, out armorClass))
            {
                txtArmorClass.Foreground = Brushes.Red;
            }
            else if (!viewModel.UpdateCurrentPlayer(armorClass, "ArmorClass"))
            {
                txtArmorClass.Foreground = Brushes.Red;
            }
        }
    }
}