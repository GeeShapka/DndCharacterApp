using DndCharacterApp.Objects.Parents;
using DndCharacterApp.UserInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public static StringBuilder Name = new StringBuilder();
        public static int Xp = 0;
        public static int Level = 0;
        public static int Hp = 0;
        public static int TempHp = 0;
        private static int _totalHp;
        public static int TotalHp
        {
            get { return _totalHp; }
            set
            {
                if (_totalHp != value)
                {
                    _totalHp = value;
                    StaticPropertyChanged?.Invoke(null, new PropertyChangedEventArgs(nameof(TotalHp)));
                }
            }
        }
        private static int _armorClass = 0;
        public static int ArmorClass
        {
            get { return _armorClass ; }
            set
            {
                if(_armorClass != value)
                {
                    _armorClass = value;
                    StaticPropertyChanged?.Invoke(null, new PropertyChangedEventArgs(nameof(ArmorClass)));
                }
            }
        }
        public static int Prof = 3;
        public static StringBuilder Alignment = new StringBuilder();
        public static BackgroundParent Background = new BackgroundParent();
        public static RaceParent Race = new RaceParent();
        public static List<ClassParent> Classes = new List<ClassParent>();
        public static int ScoreStr = 0;
        public static int ScoreDex = 0;
        public static int ScoreCon = 0;
        public static int ScoreInt = 0;
        public static int ScoreWis = 0;
        public static int ScoreCha = 0;
        public static int Speed = 0;
        public static int DeathSavesFail = 0;
        public static int DeathSavesSuccess = 0;
        public static int AttunementSlotsUsed = 0;
        public static int InititiveBonus = 0;
        public static int Age = 0;
        public static int Weight = 0;
        public static int Height = 0;
        public static StringBuilder Skin = new StringBuilder();
        public static StringBuilder Eyes = new StringBuilder();
        public static StringBuilder Hair = new StringBuilder();

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

    }//end of Player

}//end of DndCharacterApp.Objects