using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharacterApp.Objects.Player
{
    /*
	 * FILE : Playermods.cs
	 * PROJECT : DndCharacterApp
	 * PROGRAMMER : George Shapka
	 * FIRST VERSION : 10/13/2025 8:27:05 PM
	 */
    internal static class PlayerMods
    {
        //variables as modifieres

        //strength
        public static int Str;

        public static int StrSave;
        public static bool profStr = false;
        public static bool expStr = false;
        public static int addStr = 0;

        public static int Athletics = 0;
        public static bool profAthletics = false;
        public static bool expAthletics = false;
        public static int addAthletics = 0;

        //dexterity
        public static int Dex;

        public static int DexSave;
        public static bool profDex = false;
        public static bool expDex = false;
        public static int addDex = 0;

        public static int Acrobatics = 0;
        public static bool profAcrobatics = false;
        public static bool expAcrobatics = false;
        public static int addAcrobatics;

        public static int SleightOfHand = 0;
        public static bool profSleightOfHand = false;
        public static bool expSleightOfHand = false;
        public static int addSleightOfHand;

        public static int Stealth = 0;
        public static bool profStealth = false;
        public static bool expStealth = false;
        public static int addStealth;

        //constitution
        public static int Con;

        public static int ConSave;
        public static bool profCon = false;
        public static bool expCon = false;
        public static int addCon = 0;

        //intelligence
        public static int Int;

        public static int IntSave;
        public static bool profInt = false;
        public static bool expInt = false;
        public static int addInt = 0;

        public static int Arcana = 0;
        public static bool profArcana = false;
        public static bool expArcana = false;
        public static int addArcana;

        public static int History = 0;
        public static bool profHistory = false;
        public static bool expHistory = false;
        public static int addHistory;

        public static int Investigation = 0;
        public static bool profInvestigation = false;
        public static bool expInvestigation = false;
        public static int addInvestigation;

        public static int Nature = 0;
        public static bool profNature = false;
        public static bool expNature = false;
        public static int addNature;

        public static int Religion = 0;
        public static bool profReligion = false;
        public static bool expReligion = false;
        public static int addReligion;

        //wisdom
        public static int Wis;

        public static int WisSave;
        public static bool profWis = false;
        public static bool expWis = false;
        public static int addWis;

        public static int AnimalHandling = 0;
        public static bool profAnimalHandling = false;
        public static bool expAnimalHandling = false;
        public static int addAnimalHandling;

        public static int Insight = 0;
        public static bool profInsight = false;
        public static bool expInsight = false;
        public static int addInsight;

        public static int Medicine = 0;
        public static bool profMedicine = false;
        public static bool expMedicine = false;
        public static int addMedicine;

        public static int Perception = 0;
        public static bool profPerception = false;
        public static bool expPerception = false;
        public static int addPerception;

        public static int Survival = 0;
        public static bool profSurvival = false;
        public static bool expSurvival = false;
        public static int addSurvival;

        //charisma
        public static int Cha;

        public static int ChaSave;
        public static bool profCha = false;
        public static bool expCha = false;
        public static int addCha;

        public static int Deception = 0;
        public static bool profDeception = false;
        public static bool expDeception = false;
        public static int addDeception;

        public static int Intimidation = 0;
        public static bool profIntimidation = false;
        public static bool expIntimidation = false;
        public static int addIntimidation;

        public static int Performance = 0;
        public static bool profPerformance = false;
        public static bool expPerformance = false;
        public static int addPerformance;

        public static int Persuasion = 0;
        public static bool profPersuasion = false;
        public static bool expPersuasion = false;
        public static int addPersuasion;


        //methods

        /// <summary>
        /// converts a stat score into its modifier
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        public static int ScoreToMod(int score)
        {
            return (score - 10) / 2;
        }//end of ScoreToMod

    }//end of PlayerStats

}//end of DndCharacterApp.Objects