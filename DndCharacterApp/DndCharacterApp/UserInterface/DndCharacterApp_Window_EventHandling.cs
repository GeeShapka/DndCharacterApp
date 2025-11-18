using DndCharacterApp.Objects.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DndCharacterApp.UserInterface
{
    /*
	 * FILE : DndCharacterApp_Window_EventHandling.cs
	 * PROJECT : DndCharacterApp
	 * PROGRAMMER : George Shapka
	 * FIRST VERSION : 11/17/2025 8:51:48 PM
	 */
    public partial class DndCharacterApp_Window
	{
		private void UpdateStats(object? sender, PropertyChangedEventArgs e)
		{
			lblBottomHp.Content = "HP: " + Player.TotalHp.ToString();
			lblBottomAc.Content = "AC: " + Player.ArmorClass.ToString();
			lblBottomSpeed.Content = "Speed: " + Player.Speed.ToString();
		}//end of UpdateStats
	}//end of DndCharacterApp_Window_EventHandling

}//end of DndCharacterApp.UserInterface