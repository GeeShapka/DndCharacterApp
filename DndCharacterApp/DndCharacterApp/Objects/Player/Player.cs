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
		public int Xp;
		public int Hp;
		public StringBuilder Alignment = new StringBuilder();
		public Background Background = new Background();
		public Race Race = new Race();
		public List<Class> Classes = new List<Class>();
		public int ScoreStr = 0;
		public int ScoreDex = 0;
		public int ScoreCon = 0;
		public int ScoreInt = 0;
		public int ScoreWis = 0;
		public int ScoreCha = 0;
		public PlayerMods Mods = new PlayerMods();
		public int Speed;
		public int DeathSavesFail;
		public int DeathSavesSuccess;
		public int AttunementSlotsUsed;
		public int InititiveBonus;
		public int Age;
		public int Weight;
		public int Height;
		public StringBuilder Skin = new StringBuilder();
		public StringBuilder Eyes = new StringBuilder();
		public StringBuilder Hair = new StringBuilder();

    }//end of Player

}//end of DndCharacterApp.Objects