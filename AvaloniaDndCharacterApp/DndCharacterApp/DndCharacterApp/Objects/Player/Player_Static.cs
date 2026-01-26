using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
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
	internal partial class Player_Static
	{
		//variables
		public static string Name = string.Empty;
		public static int Xp = 0;
		private static int _hp;
		public static int Hp;
		public static int TempHp;
		public static int TotalHp;
		public static int ArmorClass;
		public static int Prof = 0;
		public static string Alignment = "";
		public static string Background = "";
		public static string Race = "";


		//classes
		private static int _druidLevels = 0;
		public static int DruidLevels;
		public static string DruidSubclass = string.Empty;

		public static int ScoreStr = 0;
		public static int ScoreDex = 0;
		public static int ScoreCon = 0;
		public static int ScoreInt = 0;
		public static int ScoreWis = 0;
		public static int ScoreCha = 0;
		public static int Speed;
		public static int DeathSavesFail = 0;
		public static int DeathSavesSuccess = 0;
		public static int AttunementSlotsUsed = 0;
		public static int InitiativeBonus = 0;
		public static int Age = 0;
		public static int Weight = 0;
		public static int Height = 0;
		public static StringBuilder Skin = new StringBuilder();
		public static StringBuilder Eyes = new StringBuilder();
		public static StringBuilder Hair = new StringBuilder();

		public static string NotePad = string.Empty;

		public static string AttackOneDamageType = string.Empty;
		public static string AttackTwoDamageType = string.Empty;
		public static string AttackThreeDamageType = string.Empty;
		public static string AttackFourDamageType = string.Empty;
		public static string AttackFiveDamageType = string.Empty;

        //public static event PropertyChangedEventHandler? StaticPropertyChanged;



        //methods

        /// <summary>
        /// sets all static stats from a non-static version of the class
        /// </summary>
        /// <param name="player"></param>
        public static void ImportStats(Player_NonStatic player)
		{
			Name = player.CharacterName;
			Xp = player.Xp;
			Hp = player.CurrentHp;
			TempHp = player.TempHp;
			TotalHp = player.MaxHp;
			ArmorClass = player.ArmorClass;
			Prof = player.Prof;
			Alignment = "";
			Alignment = player.Alignment;
			Background = player.Background;
			Race = player.Race;
			DruidSubclass = player.Class;
			ScoreStr = player.ScoreStr;
			ScoreDex = player.ScoreDex;
			ScoreCon = player.ScoreCon;
			ScoreInt = player.ScoreInt;
			ScoreWis = player.ScoreWis;
			ScoreCha = player.ScoreCha;
			Speed = player.Speed;
			DeathSavesFail = player.DeathSavesFail;
			DeathSavesSuccess = player.DeathSavesSuccess;
			AttunementSlotsUsed = player.AttunementSlotsUsed;
			InitiativeBonus = player.InitiativeBonus;
			Age = player.Age;
			Weight = player.Weight;
			Height = player.Height;
			Skin.Clear();
			Skin.Append(player.Skin);
			Eyes.Clear();
			Eyes.Append(player.Eyes);
			Hair.Clear();
			Hair.Append(player.Hair);

			NotePad = player.NotePad;

			PlayerMods_Static.Str = player.Str;
			PlayerMods_Static.StrSave = player.StrSave;
			PlayerMods_Static.Str = player.Str;
			PlayerMods_Static.StrSave = player.StrSave;
			PlayerMods_Static.profStr = player.profStr;
			PlayerMods_Static.expStr = player.expStr;
			PlayerMods_Static.addStr = player.addStr;
			PlayerMods_Static.Athletics = player.Athletics;
			PlayerMods_Static.profAthletics = player.profAthletics;
			PlayerMods_Static.expAthletics = player.expAthletics;
			PlayerMods_Static.addAthletics = player.addAthletics;
			PlayerMods_Static.Dex = player.Dex;
			PlayerMods_Static.DexSave = player.DexSave;
			PlayerMods_Static.profDex = player.profDex;
			PlayerMods_Static.expDex = player.expDex;
			PlayerMods_Static.addDex = player.addDex;
			PlayerMods_Static.Acrobatics = player.Acrobatics;
			PlayerMods_Static.profAcrobatics = player.profAcrobatics;
			PlayerMods_Static.expAcrobatics = player.expAcrobatics;
			PlayerMods_Static.addAcrobatics = player.addAcrobatics;
			PlayerMods_Static.SleightOfHand = player.SleightOfHand;
			PlayerMods_Static.profSleightOfHand = player.profSleightOfHand;
			PlayerMods_Static.expSleightOfHand = player.expSleightOfHand;
			PlayerMods_Static.addSleightOfHand = player.addSleightOfHand;
			PlayerMods_Static.Stealth = player.Stealth;
			PlayerMods_Static.profStealth = player.profStealth;
			PlayerMods_Static.expStealth = player.expStealth;
			PlayerMods_Static.addStealth = player.addStealth;
			PlayerMods_Static.Con = player.Con;
			PlayerMods_Static.ConSave = player.ConSave;
			PlayerMods_Static.profCon = player.profCon;
			PlayerMods_Static.expCon = player.expCon;
			PlayerMods_Static.addCon = player.addCon;
			PlayerMods_Static.Int = player.Int;
			PlayerMods_Static.IntSave = player.IntSave;
			PlayerMods_Static.profInt = player.profInt;
			PlayerMods_Static.expInt = player.expInt;
			PlayerMods_Static.addInt = player.addInt;
			PlayerMods_Static.Arcana = player.Arcana;
			PlayerMods_Static.profArcana = player.profArcana;
			PlayerMods_Static.expArcana = player.expArcana;
			PlayerMods_Static.addArcana = player.addArcana;
			PlayerMods_Static.History = player.History;
			PlayerMods_Static.profHistory = player.profHistory;
			PlayerMods_Static.expHistory = player.expHistory;
			PlayerMods_Static.addHistory = player.addHistory;
			PlayerMods_Static.Investigation = player.Investigation;
			PlayerMods_Static.profInvestigation = player.profInvestigation;
			PlayerMods_Static.expInvestigation = player.expInvestigation;
			PlayerMods_Static.addInvestigation = player.addInvestigation;
			PlayerMods_Static.Nature = player.Nature;
			PlayerMods_Static.profNature = player.profNature;
			PlayerMods_Static.expNature = player.expNature;
			PlayerMods_Static.addNature = player.addNature;
			PlayerMods_Static.Religion = player.Religion;
			PlayerMods_Static.profReligion = player.profReligion;
			PlayerMods_Static.expReligion = player.expReligion;
			PlayerMods_Static.addReligion = player.addReligion;
			PlayerMods_Static.Wis = player.Wis;
			PlayerMods_Static.WisSave = player.WisSave;
			PlayerMods_Static.profWis = player.profWis;
			PlayerMods_Static.expWis = player.expWis;
			PlayerMods_Static.addWis = player.addWis;
			PlayerMods_Static.AnimalHandling = player.AnimalHandling;
			PlayerMods_Static.profAnimalHandling = player.profAnimalHandling;
			PlayerMods_Static.expAnimalHandling = player.expAnimalHandling;
			PlayerMods_Static.addAnimalHandling = player.addAnimalHandling;
			PlayerMods_Static.Insight = player.Insight;
			PlayerMods_Static.profInsight = player.profInsight;
			PlayerMods_Static.expInsight = player.expInsight;
			PlayerMods_Static.addInsight = player.addInsight;
			PlayerMods_Static.Medicine = player.Medicine;
			PlayerMods_Static.profMedicine = player.profMedicine;
			PlayerMods_Static.expMedicine = player.expMedicine;
			PlayerMods_Static.addMedicine = player.addMedicine;
			PlayerMods_Static.Perception = player.Perception;
			PlayerMods_Static.profPerception = player.profPerception;
			PlayerMods_Static.expPerception = player.expPerception;
			PlayerMods_Static.addPerception = player.addPerception;
			PlayerMods_Static.Survival = player.Survival;
			PlayerMods_Static.profSurvival = player.profSurvival;
			PlayerMods_Static.expSurvival = player.expSurvival;
			PlayerMods_Static.addSurvival = player.addSurvival;
			PlayerMods_Static.Cha = player.Cha;
			PlayerMods_Static.ChaSave = player.ChaSave;
			PlayerMods_Static.profCha = player.profCha;
			PlayerMods_Static.expCha = player.expCha;
			PlayerMods_Static.addCha = player.addCha;
			PlayerMods_Static.Deception = player.Deception;
			PlayerMods_Static.profDeception = player.profDeception;
			PlayerMods_Static.expDeception = player.expDeception;
			PlayerMods_Static.addDeception = player.addDeception;
			PlayerMods_Static.Intimidation = player.Intimidation;
			PlayerMods_Static.profIntimidation = player.profIntimidation;
			PlayerMods_Static.expIntimidation = player.expIntimidation;
			PlayerMods_Static.addIntimidation = player.addIntimidation;
			PlayerMods_Static.Performance = player.Performance;
			PlayerMods_Static.profPerformance = player.profPerformance;
			PlayerMods_Static.expPerformance = player.expPerformance;
			PlayerMods_Static.addPerformance = player.addPerformance;
			PlayerMods_Static.Persuasion = player.Persuasion;
			PlayerMods_Static.profPersuasion = player.profPersuasion;
			PlayerMods_Static.expPersuasion = player.expPersuasion;
			PlayerMods_Static.addPersuasion = player.addPersuasion;

			UpdateAll();
		}//end of ImportStats

		public static void RemoveStats()
		{
			Name = string.Empty;
			Xp = 0;
			Hp = 0;
			TempHp = 0;
			TotalHp = 0;
			ArmorClass = 0;
			Prof = 0;
			Alignment = "";
			Background = "";
			Race = "";
			DruidLevels = 0;
			DruidSubclass = "";
			ScoreStr = 0;
			ScoreDex = 0;
			ScoreCon = 0;
			ScoreInt = 0;
			ScoreWis = 0;
			ScoreCha = 0;
			Speed = 0;
			DeathSavesFail = 0;
			DeathSavesSuccess = 0;
			AttunementSlotsUsed = 0;
			InitiativeBonus = 0;
			Age = 0;
			Weight = 0;
			Height = 0;
			Skin.Clear();
			Eyes.Clear();
			Hair.Clear();

			NotePad = string.Empty;

			PlayerMods_Static.Str = 0;
			PlayerMods_Static.StrSave = 0;
			PlayerMods_Static.profStr = false;
			PlayerMods_Static.expStr = false;
			PlayerMods_Static.addStr = 0;
			PlayerMods_Static.Athletics = 0;
			PlayerMods_Static.profAthletics = false;
			PlayerMods_Static.expAthletics = false;
			PlayerMods_Static.addAthletics = 0;
			PlayerMods_Static.Dex = 0;
			PlayerMods_Static.DexSave = 0;
			PlayerMods_Static.profDex = false;
			PlayerMods_Static.expDex = false;
			PlayerMods_Static.addDex = 0;
			PlayerMods_Static.Acrobatics = 0;
			PlayerMods_Static.profAcrobatics = false;
			PlayerMods_Static.expAcrobatics = false;
			PlayerMods_Static.addAcrobatics = 0;
			PlayerMods_Static.SleightOfHand = 0;
			PlayerMods_Static.profSleightOfHand = false;
			PlayerMods_Static.expSleightOfHand = false;
			PlayerMods_Static.addSleightOfHand = 0;
			PlayerMods_Static.Stealth = 0;
			PlayerMods_Static.profStealth = false;
			PlayerMods_Static.expStealth = false;
			PlayerMods_Static.addStealth = 0;
			PlayerMods_Static.Con = 0;
			PlayerMods_Static.ConSave = 0;
			PlayerMods_Static.profCon = false;
			PlayerMods_Static.expCon = false;
			PlayerMods_Static.addCon = 0;
			PlayerMods_Static.Int = 0;
			PlayerMods_Static.IntSave = 0;
			PlayerMods_Static.profInt = false;
			PlayerMods_Static.expInt = false;
			PlayerMods_Static.addInt = 0;
			PlayerMods_Static.Arcana = 0;
			PlayerMods_Static.profArcana = false;
			PlayerMods_Static.expArcana = false;
			PlayerMods_Static.addArcana = 0;
			PlayerMods_Static.History = 0;
			PlayerMods_Static.profHistory = false;
			PlayerMods_Static.expHistory = false;
			PlayerMods_Static.addHistory = 0;
			PlayerMods_Static.Investigation = 0;
			PlayerMods_Static.profInvestigation = false;
			PlayerMods_Static.expInvestigation = false;
			PlayerMods_Static.addInvestigation = 0;
			PlayerMods_Static.Nature = 0;
			PlayerMods_Static.profNature = false;
			PlayerMods_Static.expNature = false;
			PlayerMods_Static.addNature = 0;
			PlayerMods_Static.Religion = 0;
			PlayerMods_Static.profReligion = false;
			PlayerMods_Static.expReligion = false;
			PlayerMods_Static.addReligion = 0;
			PlayerMods_Static.Wis = 0;
			PlayerMods_Static.WisSave = 0;
			PlayerMods_Static.profWis = false;
			PlayerMods_Static.expWis = false;
			PlayerMods_Static.addWis = 0;
			PlayerMods_Static.AnimalHandling = 0;
			PlayerMods_Static.profAnimalHandling = false;
			PlayerMods_Static.expAnimalHandling = false;
			PlayerMods_Static.addAnimalHandling = 0;
			PlayerMods_Static.Insight = 0;
			PlayerMods_Static.profInsight = false;
			PlayerMods_Static.expInsight = false;
			PlayerMods_Static.addInsight = 0;
			PlayerMods_Static.Medicine = 0;
			PlayerMods_Static.profMedicine = false;
			PlayerMods_Static.expMedicine = false;
			PlayerMods_Static.addMedicine = 0;
			PlayerMods_Static.Perception = 0;
			PlayerMods_Static.profPerception = false;
			PlayerMods_Static.expPerception = false;
			PlayerMods_Static.addPerception = 0;
			PlayerMods_Static.Survival = 0;
			PlayerMods_Static.profSurvival = false;
			PlayerMods_Static.expSurvival = false;
			PlayerMods_Static.addSurvival = 0;
			PlayerMods_Static.Cha = 0;
			PlayerMods_Static.ChaSave = 0;
			PlayerMods_Static.profCha = false;
			PlayerMods_Static.expCha = false;
			PlayerMods_Static.addCha = 0;
			PlayerMods_Static.Deception = 0;
			PlayerMods_Static.profDeception = false;
			PlayerMods_Static.expDeception = false;
			PlayerMods_Static.addDeception = 0;
			PlayerMods_Static.Intimidation = 0;
			PlayerMods_Static.profIntimidation = false;
			PlayerMods_Static.expIntimidation = false;
			PlayerMods_Static.addIntimidation = 0;
			PlayerMods_Static.Performance = 0;
			PlayerMods_Static.profPerformance = false;
			PlayerMods_Static.expPerformance = false;
			PlayerMods_Static.addPerformance = 0;
			PlayerMods_Static.Persuasion = 0;
			PlayerMods_Static.profPersuasion = false;
			PlayerMods_Static.expPersuasion = false;
			PlayerMods_Static.addPersuasion = 0;

			UpdateAll();
		}

	}//end of Player

}//end of DndCharacterApp.Objects