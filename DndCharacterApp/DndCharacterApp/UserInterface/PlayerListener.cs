using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCharacterApp.Objects.Player;

namespace DndCharacterApp.UserInterface
{
    /*
	 * FILE : PlayerListener.cs
	 * PROJECT : DndCharacterApp
	 * PROGRAMMER : George Shapka
	 * FIRST VERSION : 11/8/2025 12:38:02 AM
	 */
    internal class PlayerListener : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler? PropertyChanged;

		public int TotalHp
		{
			get { return Player.TotalHp; }
		}

		public int ArmorClass
		{
			get { return Player.ArmorClass; }
		}

		public PlayerListener()
		{
			Player.StaticPropertyChanged += OnTotalHpChanged;
			Player.StaticPropertyChanged += OnArmorClassChanged;
		}

		private void OnTotalHpChanged(object? sender, PropertyChangedEventArgs e)
		{
			if(e.PropertyName == nameof(Player.TotalHp))
			{
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TotalHp)));
			}
		}

		private void OnArmorClassChanged(object? sender, PropertyChangedEventArgs e)
		{
			if(e.PropertyName == nameof(Player.ArmorClass))
			{
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ArmorClass)));
			}
		}
    }//end of PlayerListener

}//end of DndCharacterApp.UserInterface