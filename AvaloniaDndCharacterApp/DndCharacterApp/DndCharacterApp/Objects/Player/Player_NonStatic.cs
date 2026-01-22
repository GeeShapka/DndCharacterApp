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
			Name = string.Empty;
			Alignment = string.Empty;
			Background = string.Empty;
			Race = string.Empty;
			DruidSubclass = string.Empty;
			Skin = string.Empty;
			Eyes = string.Empty;
			Hair = string.Empty;
			NotePad = string.Empty;
		}

		public int Id;
		public string Name;
		public int Xp;
		public int Hp;
		public int TempHp;
		public int TotalHp;
		public int ArmorClass;
		public int Prof;
		public string Alignment;
		public string Background;
		public string Race;
		public int DruidLevels;
		public string DruidSubclass;
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
		public string Skin;
		public string Eyes;
		public string Hair;

		public string NotePad;

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