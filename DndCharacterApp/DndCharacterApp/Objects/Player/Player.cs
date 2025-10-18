using DndCharacterApp.Objects.Parents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharacterApp.Objects.Player
{
    /*
	 * FILE : Player.cs
	 * PROJECT : DndCharacterApp
	 * PROGRAMMER : George Shapka
	 * FIRST VERSION : 10/13/2025 8:19:45 PM
	 */
    internal partial class Player
    {
		//variables
		public StringBuilder Name = new StringBuilder();
		public int Xp = 0;
		public int Level = 0;
		public int Hp = 0;
		public int Prof = 0;
		public StringBuilder Alignment = new StringBuilder();
		public BackgroundParent Background = new BackgroundParent();
		public RaceParent Race = new RaceParent();
		public List<ClassParent> Classes = new List<ClassParent>();
		public int ScoreStr = 0;
		public int ScoreDex = 0;
		public int ScoreCon = 0;
		public int ScoreInt = 0;
		public int ScoreWis = 0;
		public int ScoreCha = 0;
		public PlayerMods Mods = new PlayerMods();
		public int Speed = 0;
		public int DeathSavesFail = 0;
		public int DeathSavesSuccess = 0;
		public int AttunementSlotsUsed = 0;
		public int InititiveBonus = 0;
		public int Age = 0;
		public int Weight = 0;
		public int Height = 0;
		public StringBuilder Skin = new StringBuilder();
		public StringBuilder Eyes = new StringBuilder();
		public StringBuilder Hair = new StringBuilder();



		//methods

		/// <summary>
		/// updates player level based on xp, and updates player pb bases on level
		/// </summary>
		public void UpdateLevel()
		{
			Level = Xp switch
			{
				< 300		=> 1,
				< 900		=> 2,
				< 2700		=> 3,
				< 6500		=> 4,
				< 14000		=> 5,
				< 23000		=> 6,
				< 34000		=> 7,
				< 48000		=> 8,
				< 64000		=> 9,
				< 85000		=> 10,
				< 100000	=> 11,
				< 120000	=> 12,
				< 140000	=> 13,
				< 165000	=> 14,
				< 195000	=> 15,
				< 225000	=> 16,
				< 265000	=> 17,
				< 305000	=> 18,
				< 355000	=> 19,
				> 355000	=> 20,
				_			=> 0	
			};//end of switch

			Prof = Level switch
			{
				< 5		=> 2,
				< 9		=> 3,
				< 13	=> 4,
				< 17	=> 5,
				> 17	=> 6,
				_		=> 2
			};//end of switch
		}//end of UpdateLevel

	}//end of Player

}//end of DndCharacterApp.Objects