using System;
using System.Collections.Generic;
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
    internal class PlayerMods
    {
        //variables as modifieres
        public int Str;
        public bool profStr = false;

        public int Athletics = 0;
        public bool profAthletics = false;
        public bool expAthletics = false;
        public int addAthletics;

        public int Dex;
        public bool profDex = false;
        public int Acrobatics = 0;
        public bool profAcrobatics = false;
        public bool expAcrobatics = false;
        public int addAcrobatics;

        public int SleightOfHand = 0;
        public bool profSleightOfHand = false;
        public bool expSleightOfHand = false;
        public int addSleightOfHand;

        public int Stealth = 0;
        public bool profStealth = false;
        public bool expStealth = false;
        public int addStealth;

        public int Con;
        public bool profCon = false;

        public int Int;
        public bool profInt = false;

        public int Arcana = 0;
        public bool profArcana = false;
        public bool expArcana = false;
        public int addArcana;

        public int History = 0;
        public bool profHistory = false;
        public bool expHistory = false;
        public int addHistory;

        public int Investigation = 0;
        public bool profInvestigation = false;
        public bool expInvestigation = false;
        public int addInvestigation;

        public int Nature = 0;
        public bool profNature = false;
        public bool expNature = false;
        public int addNature;

        public int Religion = 0;
        public bool profReligion = false;
        public bool expReligion = false;
        public int addReligion;

        public int Wis;
        public bool profWis = false;

        public int AnimalHandling = 0;
        public bool profAnimalHandling = false;
        public bool expAnimalHandling = false;
        public int addAnimalHandling;

        public int Insight = 0;
        public bool profInsight = false;
        public bool expInsight = false;
        public int addInsight;

        public int Medicine = 0;
        public bool profMedicine = false;
        public bool expMedicine = false;
        public int addMedicine;

        public int Perception = 0;
        public bool profPerception = false;
        public bool expPerception = false;
        public int addPerception;

        public int Survival = 0;
        public bool profSurvival = false;
        public bool expSurvival = false;
        public int addSurvival;

        public int Cha;
        public bool profCha = false;

        public int Deception = 0;
        public bool profDeception = false;
        public bool expDeception = false;
        public int addDeception;

        public int Intimidation = 0;
        public bool profIntimidation = false;
        public bool expIntimidation = false;
        public int addIntimidation;

        public int Performance = 0;
        public bool profPerformance = false;
        public bool expPerformance = false;
        public int addPerformance;

        public int Persuasion = 0;
        public bool profPersuasion = false;
        public bool expPersuasion = false;
        public int addPersuasion;


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