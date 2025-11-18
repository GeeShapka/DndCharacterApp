using DndCharacterApp.Objects.Parents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharacterApp.Objects.Player
{
    /*
	 * FILE : Player_NonStatic.cs
	 * PROJECT : DndCharacterApp
	 * PROGRAMMER : George Shapka
	 * FIRST VERSION : 11/17/2025 9:28:32 PM
	 */
    public class Player_NonStatic
    {
        public Player_NonStatic()
		{
			Name = Player.Name.ToString();
			Xp = Player.Xp;
			Level = Player.Level;
			Hp = Player.Hp;
			TempHp = Player.TempHp;
			TotalHp = Player.TotalHp;
			ArmorClass = Player.ArmorClass;
			Prof = Player.Prof;
			Alignment = Player.Alignment.ToString();
			Background = Player.Background;
			Race = Player.Race;
			Classes = Player.Classes;
			ScoreStr = Player.ScoreStr;
			ScoreDex = Player.ScoreDex;
			ScoreCon = Player.ScoreCon;
			ScoreInt = Player.ScoreInt;
			ScoreWis = Player.ScoreWis;
			ScoreCha = Player.ScoreCha;
			Speed = Player.Speed;
			DeathSavesFail = Player.DeathSavesFail;
			DeathSavesSuccess = Player.DeathSavesSuccess;
			AttunementSlotsUsed = Player.AttunementSlotsUsed;
			InitiativeBonus = Player.InitiativeBonus;
			Age = Player.Age;
			Weight = Player.Weight;
			Height = Player.Height;
			Skin = Player.Skin.ToString();
            Eyes = Player.Eyes.ToString();
            Hair = Player.Hair.ToString();
		}

		public String Name;
		public int Xp;
		public int Level;
		public int Hp;
		public int TempHp;
		public int TotalHp;
		public int ArmorClass;
		public int Prof;
		public string? Alignment;
		public BackgroundParent? Background;
		public RaceParent? Race;
		public List<ClassParent>? Classes;
		public int ScoreStr;
		public int ScoreDex;
		public int ScoreCon;
		public int ScoreInt;
		public int ScoreWis;
		public int ScoreCha;
		public int Speed;
		public int DeathSavesFail;
		public int DeathSavesSuccess;
		public int AttunementSlotsUsed;
		public int InitiativeBonus;
		public int Age;
		public int Weight;
		public int Height;
		public string? Skin;
		public string? Eyes;
		public string? Hair;
    }//end of Player_NonStatic

}//end of DndCharacterApp.Objects.Player