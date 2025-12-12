using DndCharacterApp.Objects.Parents;
using DndCharacterApp.UserInterface;
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
	internal partial class Player
	{
		//variables
		public static string? Name;
		public static int			Xp = 0;
		public static int			Level = 0;
		private static int			_hp;
		public static int			Hp
		{
			get { return _hp; }
			set
			{
				_hp = value;
				TotalHp = _hp + _tempHp;
				StaticPropertyChanged?.Invoke(null, new PropertyChangedEventArgs(nameof(Hp)));
			}
		}

		private static int			_tempHp;
		public static int			TempHp
		{
			get { return _tempHp; }
			set
			{
				_tempHp = value;
				TotalHp = _hp + _tempHp;
				StaticPropertyChanged?.Invoke(null, new PropertyChangedEventArgs(nameof(TempHp)));
			}
		}

		private static int			_totalHp;
		public static int			TotalHp
		{
			get { return _totalHp; }
			set
			{
				_totalHp = value;
				StaticPropertyChanged?.Invoke(null, new PropertyChangedEventArgs(nameof(TotalHp)));
			}
		}

		private static int			_armorClass = 0;
		public static int			ArmorClass
		{
			get { return			_armorClass ; }
			set
			{
				if(_armorClass != value)
				{
					_armorClass = value;
					StaticPropertyChanged?.Invoke(null, new PropertyChangedEventArgs(nameof(ArmorClass)));
				}
			}
		}
		public static int			Prof = 0;
		public static StringBuilder Alignment = new StringBuilder();
		public static BackgroundParent? Background = new BackgroundParent();
		public static RaceParent?   Race = new RaceParent();
		public static List<ClassParent> Classes = new List<ClassParent>();

        private static int _druidLevels = 0;
        public static int DruidLevels
        {
            get { return _druidLevels; }
            set
            {
                if( _druidLevels != value)
                {
                    _druidLevels= value;
                    StaticPropertyChanged?.Invoke(null, new PropertyChangedEventArgs(nameof(DruidLevels)));
                }
            }
        }

		public static int			ScoreStr = 0;
		public static int			ScoreDex = 0;
		public static int			ScoreCon = 0;
		public static int			ScoreInt = 0;
		public static int			ScoreWis = 0;
		public static int			ScoreCha = 0;
		private static int _speed;
		public static int			Speed
		{
			get { return _speed; }
			set
			{
				_speed = value;
                StaticPropertyChanged?.Invoke(null, new PropertyChangedEventArgs(nameof(Speed)));
            }
		}
		public static int			DeathSavesFail = 0;
		public static int			DeathSavesSuccess = 0;
		public static int			AttunementSlotsUsed = 0;
		public static int			InitiativeBonus = 0;
		public static int			Age = 0;
		public static int			Weight = 0;
		public static int           Height = 0;
		public static StringBuilder Skin = new StringBuilder();
		public static StringBuilder Eyes = new StringBuilder();
		public static StringBuilder Hair = new StringBuilder();

        public static string?       NotePad;

		public static event PropertyChangedEventHandler? StaticPropertyChanged;



		//methods

		/// <summary>
		/// updates player level based on xp, and updates player pb bases on level
		/// </summary>
		public static void UpdateLevel()
		{
			Level = Xp switch
			{
				< 300 => 1,
				< 900 => 2,
				< 2700 => 3,
				< 6500 => 4,
				< 14000 => 5,
				< 23000 => 6,
				< 34000 => 7,
				< 48000 => 8,
				< 64000 => 9,
				< 85000 => 10,
				< 100000 => 11,
				< 120000 => 12,
				< 140000 => 13,
				< 165000 => 14,
				< 195000 => 15,
				< 225000 => 16,
				< 265000 => 17,
				< 305000 => 18,
				< 355000 => 19,
				> 355000 => 20,
				_ => 0
			};//end of switch

			Prof = Level switch
			{
				< 5 => 2,
				< 9 => 3,
				< 13 => 4,
				< 17 => 5,
				> 17 => 6,
				_ => 2
			};//end of switch
		}//end of UpdateLevel

		/// <summary>
		/// sets all static stats from a non-static version of the class
		/// </summary>
		/// <param name="player"></param>
		public static void ImportStats(Player_NonStatic player)
		{
			Name = player.Name;
			Xp = player.Xp;
			Level = player.Level;
			Hp = player.Hp;
			TempHp = player.TempHp;
			TotalHp = player.TotalHp;
			ArmorClass = player.ArmorClass;
			Prof = player.Prof;
			Alignment.Clear();
			Alignment.Append(player.Alignment);
			Background = player.Background;
			Race = player.Race;
			Classes = player.Classes ?? new List<ClassParent>();
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

			PlayerMods.Str = player.Str;
			PlayerMods.StrSave = player.StrSave;
            PlayerMods.Str = player.Str;
            PlayerMods.StrSave = player.StrSave;
            PlayerMods.profStr = player.profStr;
            PlayerMods.expStr = player.expStr;
            PlayerMods.addStr = player.addStr;
            PlayerMods.Athletics = player.Athletics;
            PlayerMods.profAthletics = player.profAthletics;
            PlayerMods.expAthletics = player.expAthletics;
            PlayerMods.addAthletics = player.addAthletics;
            PlayerMods.Dex = player.Dex;
            PlayerMods.DexSave = player.DexSave;
            PlayerMods.profDex = player.profDex;
            PlayerMods.expDex = player.expDex;
            PlayerMods.addDex = player.addDex;
            PlayerMods.Acrobatics = player.Acrobatics;
            PlayerMods.profAcrobatics = player.profAcrobatics;
            PlayerMods.expAcrobatics = player.expAcrobatics;
            PlayerMods.addAcrobatics = player.addAcrobatics;
            PlayerMods.SleightOfHand = player.SleightOfHand;
            PlayerMods.profSleightOfHand = player.profSleightOfHand;
            PlayerMods.expSleightOfHand = player.expSleightOfHand;
            PlayerMods.addSleightOfHand = player.addSleightOfHand;
            PlayerMods.Stealth = player.Stealth;
            PlayerMods.profStealth = player.profStealth;
            PlayerMods.expStealth = player.expStealth;
            PlayerMods.addStealth = player.addStealth;
            PlayerMods.Con = player.Con;
            PlayerMods.ConSave = player.ConSave;
            PlayerMods.profCon = player.profCon;
            PlayerMods.expCon = player.expCon;
            PlayerMods.addCon = player.addCon;
            PlayerMods.Int = player.Int;
            PlayerMods.IntSave = player.IntSave;
            PlayerMods.profInt = player.profInt;
            PlayerMods.expInt = player.expInt;
            PlayerMods.addInt = player.addInt;
            PlayerMods.Arcana = player.Arcana;
            PlayerMods.profArcana = player.profArcana;
            PlayerMods.expArcana = player.expArcana;
            PlayerMods.addArcana = player.addArcana;
            PlayerMods.History = player.History;
            PlayerMods.profHistory = player.profHistory;
            PlayerMods.expHistory = player.expHistory;
            PlayerMods.addHistory = player.addHistory;
            PlayerMods.Investigation = player.Investigation;
            PlayerMods.profInvestigation = player.profInvestigation;
            PlayerMods.expInvestigation = player.expInvestigation;
            PlayerMods.addInvestigation = player.addInvestigation;
            PlayerMods.Nature = player.Nature;
            PlayerMods.profNature = player.profNature;
            PlayerMods.expNature = player.expNature;
            PlayerMods.addNature = player.addNature;
            PlayerMods.Religion = player.Religion;
            PlayerMods.profReligion = player.profReligion;
            PlayerMods.expReligion = player.expReligion;
            PlayerMods.addReligion = player.addReligion;
            PlayerMods.Wis = player.Wis;
            PlayerMods.WisSave = player.WisSave;
            PlayerMods.profWis = player.profWis;
            PlayerMods.expWis = player.expWis;
            PlayerMods.addWis = player.addWis;
            PlayerMods.AnimalHandling = player.AnimalHandling;
            PlayerMods.profAnimalHandling = player.profAnimalHandling;
            PlayerMods.expAnimalHandling = player.expAnimalHandling;
            PlayerMods.addAnimalHandling = player.addAnimalHandling;
            PlayerMods.Insight = player.Insight;
            PlayerMods.profInsight = player.profInsight;
            PlayerMods.expInsight = player.expInsight;
            PlayerMods.addInsight = player.addInsight;
            PlayerMods.Medicine = player.Medicine;
            PlayerMods.profMedicine = player.profMedicine;
            PlayerMods.expMedicine = player.expMedicine;
            PlayerMods.addMedicine = player.addMedicine;
            PlayerMods.Perception = player.Perception;
            PlayerMods.profPerception = player.profPerception;
            PlayerMods.expPerception = player.expPerception;
            PlayerMods.addPerception = player.addPerception;
            PlayerMods.Survival = player.Survival;
            PlayerMods.profSurvival = player.profSurvival;
            PlayerMods.expSurvival = player.expSurvival;
            PlayerMods.addSurvival = player.addSurvival;
            PlayerMods.Cha = player.Cha;
            PlayerMods.ChaSave = player.ChaSave;
            PlayerMods.profCha = player.profCha;
            PlayerMods.expCha = player.expCha;
            PlayerMods.addCha = player.addCha;
            PlayerMods.Deception = player.Deception;
            PlayerMods.profDeception = player.profDeception;
            PlayerMods.expDeception = player.expDeception;
            PlayerMods.addDeception = player.addDeception;
            PlayerMods.Intimidation = player.Intimidation;
            PlayerMods.profIntimidation = player.profIntimidation;
            PlayerMods.expIntimidation = player.expIntimidation;
            PlayerMods.addIntimidation = player.addIntimidation;
            PlayerMods.Performance = player.Performance;
            PlayerMods.profPerformance = player.profPerformance;
            PlayerMods.expPerformance = player.expPerformance;
            PlayerMods.addPerformance = player.addPerformance;
            PlayerMods.Persuasion = player.Persuasion;
            PlayerMods.profPersuasion = player.profPersuasion;
            PlayerMods.expPersuasion = player.expPersuasion;
            PlayerMods.addPersuasion = player.addPersuasion;

            UpdateAll();
        }//end of ImportStats

        public static void RemoveStats()
		{
            Name = string.Empty;
            Xp = 0;
            Level = 0;
            Hp = 0;
            TempHp = 0;
            TotalHp = 0;
            ArmorClass = 0;
            Prof = 0;
            Alignment.Clear();
            Background = null;
            Race = null;
            Classes.Clear();
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

            PlayerMods.Str = 0;
            PlayerMods.StrSave = 0;
            PlayerMods.profStr = false;
            PlayerMods.expStr = false;
            PlayerMods.addStr = 0;
            PlayerMods.Athletics = 0;
            PlayerMods.profAthletics = false;
            PlayerMods.expAthletics = false;
            PlayerMods.addAthletics = 0;
            PlayerMods.Dex = 0;
            PlayerMods.DexSave = 0;
            PlayerMods.profDex = false;
            PlayerMods.expDex = false;
            PlayerMods.addDex = 0;
            PlayerMods.Acrobatics = 0;
            PlayerMods.profAcrobatics = false;
            PlayerMods.expAcrobatics = false;
            PlayerMods.addAcrobatics = 0;
            PlayerMods.SleightOfHand = 0;
            PlayerMods.profSleightOfHand = false;
            PlayerMods.expSleightOfHand = false;
            PlayerMods.addSleightOfHand = 0;
            PlayerMods.Stealth = 0;
            PlayerMods.profStealth = false;
            PlayerMods.expStealth = false;
            PlayerMods.addStealth = 0;
            PlayerMods.Con = 0;
            PlayerMods.ConSave = 0;
            PlayerMods.profCon = false;
            PlayerMods.expCon = false;
            PlayerMods.addCon = 0;
            PlayerMods.Int = 0;
            PlayerMods.IntSave = 0;
            PlayerMods.profInt = false;
            PlayerMods.expInt = false;
            PlayerMods.addInt = 0;
            PlayerMods.Arcana = 0;
            PlayerMods.profArcana = false;
            PlayerMods.expArcana = false;
            PlayerMods.addArcana = 0;
            PlayerMods.History = 0;
            PlayerMods.profHistory = false;
            PlayerMods.expHistory = false;
            PlayerMods.addHistory = 0;
            PlayerMods.Investigation = 0;
            PlayerMods.profInvestigation = false;
            PlayerMods.expInvestigation = false;
            PlayerMods.addInvestigation = 0;
            PlayerMods.Nature = 0;
            PlayerMods.profNature = false;
            PlayerMods.expNature = false;
            PlayerMods.addNature = 0;
            PlayerMods.Religion = 0;
            PlayerMods.profReligion = false;
            PlayerMods.expReligion = false;
            PlayerMods.addReligion = 0;
            PlayerMods.Wis = 0;
            PlayerMods.WisSave = 0;
            PlayerMods.profWis = false;
            PlayerMods.expWis = false;
            PlayerMods.addWis = 0;
            PlayerMods.AnimalHandling = 0;
            PlayerMods.profAnimalHandling = false;
            PlayerMods.expAnimalHandling = false;
            PlayerMods.addAnimalHandling = 0;
            PlayerMods.Insight = 0;
            PlayerMods.profInsight = false;
            PlayerMods.expInsight = false;
            PlayerMods.addInsight = 0;
            PlayerMods.Medicine = 0;
            PlayerMods.profMedicine = false;
            PlayerMods.expMedicine = false;
            PlayerMods.addMedicine = 0;
            PlayerMods.Perception = 0;
            PlayerMods.profPerception = false;
            PlayerMods.expPerception = false;
            PlayerMods.addPerception = 0;
            PlayerMods.Survival = 0;
            PlayerMods.profSurvival = false;
            PlayerMods.expSurvival = false;
            PlayerMods.addSurvival = 0;
            PlayerMods.Cha = 0;
            PlayerMods.ChaSave = 0;
            PlayerMods.profCha = false;
            PlayerMods.expCha = false;
            PlayerMods.addCha = 0;
            PlayerMods.Deception = 0;
            PlayerMods.profDeception = false;
            PlayerMods.expDeception = false;
            PlayerMods.addDeception = 0;
            PlayerMods.Intimidation = 0;
            PlayerMods.profIntimidation = false;
            PlayerMods.expIntimidation = false;
            PlayerMods.addIntimidation = 0;
            PlayerMods.Performance = 0;
            PlayerMods.profPerformance = false;
            PlayerMods.expPerformance = false;
            PlayerMods.addPerformance = 0;
            PlayerMods.Persuasion = 0;
            PlayerMods.profPersuasion = false;
            PlayerMods.expPersuasion = false;
            PlayerMods.addPersuasion = 0;

            UpdateAll();
        }

    }//end of Player

}//end of DndCharacterApp.Objects