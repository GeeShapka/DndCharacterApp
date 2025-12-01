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

			Str = PlayerMods.Str;
			StrSave = PlayerMods.StrSave;
			profStr = PlayerMods.profStr;
			expStr = PlayerMods.expStr;
			addStr = PlayerMods.addStr;
			Athletics = PlayerMods.Athletics;
			profAthletics = PlayerMods.profAthletics;
			expAthletics = PlayerMods.expAthletics;
			addAthletics = PlayerMods.addAthletics;
			Dex = PlayerMods.Dex;
			DexSave = PlayerMods.DexSave;
			profDex = PlayerMods.profDex;
			expDex = PlayerMods.expDex;
			addDex = PlayerMods.addDex;
			Acrobatics = PlayerMods.Acrobatics;
			profAcrobatics = PlayerMods.profAcrobatics;
			expAcrobatics = PlayerMods.expAcrobatics;
			addAcrobatics = PlayerMods.addAcrobatics;
			SleightOfHand = PlayerMods.SleightOfHand;
			profSleightOfHand = PlayerMods.profSleightOfHand;
			expSleightOfHand = PlayerMods.expSleightOfHand;
			addSleightOfHand = PlayerMods.addSleightOfHand;
			Stealth = PlayerMods.Stealth;
			profStealth = PlayerMods.profStealth;
			expStealth = PlayerMods.expStealth;
			addStealth = PlayerMods.addStealth;
			Con = PlayerMods.Con;
			ConSave = PlayerMods.ConSave;
			profCon = PlayerMods.profCon;
			expCon = PlayerMods.expCon;
			addCon = PlayerMods.addCon;
			Int = PlayerMods.Int;
			IntSave = PlayerMods.IntSave;
			profInt = PlayerMods.profInt;
			expInt = PlayerMods.expInt;
			addInt = PlayerMods.addInt;
			Arcana = PlayerMods.Arcana;
			profArcana = PlayerMods.profArcana;
			expArcana = PlayerMods.expArcana;
			addArcana = PlayerMods.addArcana;
			History = PlayerMods.History;
			profHistory = PlayerMods.profHistory;
			expHistory = PlayerMods.expHistory;
			addHistory = PlayerMods.addHistory;
			Investigation = PlayerMods.Investigation;
			profInvestigation = PlayerMods.profInvestigation;
			expInvestigation = PlayerMods.expInvestigation;
			addInvestigation = PlayerMods.addInvestigation;
			Nature = PlayerMods.Nature;
			profNature = PlayerMods.profNature;
			expNature = PlayerMods.expNature;
			addNature = PlayerMods.addNature;
			Religion = PlayerMods.Religion;
			profReligion = PlayerMods.profReligion;
			expReligion = PlayerMods.expReligion;
			addReligion = PlayerMods.addReligion;
			Wis = PlayerMods.Wis;
			WisSave = PlayerMods.WisSave;
			profWis = PlayerMods.profWis;
			expWis = PlayerMods.expWis;
			addWis = PlayerMods.addWis;
			AnimalHandling = PlayerMods.AnimalHandling;
			profAnimalHandling = PlayerMods.profAnimalHandling;
			expAnimalHandling = PlayerMods.expAnimalHandling;
			addAnimalHandling = PlayerMods.addAnimalHandling;
			Insight = PlayerMods.Insight;
			profInsight = PlayerMods.profInsight;
			expInsight = PlayerMods.expInsight;
			addInsight = PlayerMods.addInsight;
			Medicine = PlayerMods.Medicine;
			profMedicine = PlayerMods.profMedicine;
			expMedicine = PlayerMods.expMedicine;
			addMedicine = PlayerMods.addMedicine;
			Perception = PlayerMods.Perception;
			profPerception = PlayerMods.profPerception;
			expPerception = PlayerMods.expPerception;
			addPerception = PlayerMods.addPerception;
			Survival = PlayerMods.Survival;
			profSurvival = PlayerMods.profSurvival;
			expSurvival = PlayerMods.expSurvival;
			addSurvival = PlayerMods.addSurvival;
			Cha = PlayerMods.Cha;
			ChaSave = PlayerMods.ChaSave;
			profCha = PlayerMods.profCha;
			expCha = PlayerMods.expCha;
			addCha = PlayerMods.addCha;
			Deception = PlayerMods.Deception;
			profDeception = PlayerMods.profDeception;
			expDeception = PlayerMods.expDeception;
			addDeception = PlayerMods.addDeception;
			Intimidation = PlayerMods.Intimidation;
			profIntimidation = PlayerMods.profIntimidation;
			expIntimidation = PlayerMods.expIntimidation;
			addIntimidation = PlayerMods.addIntimidation;
			Performance = PlayerMods.Performance;
			profPerformance = PlayerMods.profPerformance;
			expPerformance = PlayerMods.expPerformance;
			addPerformance = PlayerMods.addPerformance;
			Persuasion = PlayerMods.Persuasion;
			profPersuasion = PlayerMods.profPersuasion;
			expPersuasion = PlayerMods.expPersuasion;
			addPersuasion = PlayerMods.addPersuasion;
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

		//player mods variables
		// strength
		public int Str;

		public int StrSave;
		public bool profStr;
		public bool expStr;
		public int addStr;

		public int Athletics;
		public bool profAthletics;
		public bool expAthletics;
		public int addAthletics;

		// dexterity
		public int Dex;

		public int DexSave;
		public bool profDex;
		public bool expDex;
		public int addDex;

		public int Acrobatics;
		public bool profAcrobatics;
		public bool expAcrobatics;
		public int addAcrobatics;

		public int SleightOfHand;
		public bool profSleightOfHand;
		public bool expSleightOfHand;
		public int addSleightOfHand;

		public int Stealth;
		public bool profStealth;
		public bool expStealth;
		public int addStealth;

		// constitution
		public int Con;

		public int ConSave;
		public bool profCon;
		public bool expCon;
		public int addCon;

		// intelligence
		public int Int;

		public int IntSave;
		public bool profInt;
		public bool expInt;
		public int addInt;

		public int Arcana;
		public bool profArcana;
		public bool expArcana;
		public int addArcana;

		public int History;
		public bool profHistory;
		public bool expHistory;
		public int addHistory;

		public int Investigation;
		public bool profInvestigation;
		public bool expInvestigation;
		public int addInvestigation;

		public int Nature;
		public bool profNature;
		public bool expNature;
		public int addNature;

		public int Religion;
		public bool profReligion;
		public bool expReligion;
		public int addReligion;

		// wisdom
		public int Wis;

		public int WisSave;
		public bool profWis;
		public bool expWis;
		public int addWis;

		public int AnimalHandling;
		public bool profAnimalHandling;
		public bool expAnimalHandling;
		public int addAnimalHandling;

		public int Insight;
		public bool profInsight;
		public bool expInsight;
		public int addInsight;

		public int Medicine;
		public bool profMedicine;
		public bool expMedicine;
		public int addMedicine;

		public int Perception;
		public bool profPerception;
		public bool expPerception;
		public int addPerception;

		public int Survival;
		public bool profSurvival;
		public bool expSurvival;
		public int addSurvival;

		// charisma
		public int Cha;

		public int ChaSave;
		public bool profCha;
		public bool expCha;
		public int addCha;

		public int Deception;
		public bool profDeception;
		public bool expDeception;
		public int addDeception;

		public int Intimidation;
		public bool profIntimidation;
		public bool expIntimidation;
		public int addIntimidation;

		public int Performance;
		public bool profPerformance;
		public bool expPerformance;
		public int addPerformance;

		public int Persuasion;
		public bool profPersuasion;
		public bool expPersuasion;
		public int addPersuasion;





	}//end of Player_NonStatic

}//end of DndCharacterApp.Objects.Player