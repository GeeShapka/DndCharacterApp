using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharacterApp.Objects
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
        public bool profAthletics = false;
        public bool expAthletics = false;
        public int addAthletics;
        public int Dex;
        public bool profDex = false;
        public bool profAcrobatics = false;
        public bool expAcrobatics = false;
        public int addAcrobatics;
        public bool profSleightOfHand = false;
        public bool expSleightOfHand = false;
        public int addSleightOfHand;
        public bool profStealth = false;
        public bool expStealth = false;
        public int addStealth   ;
        public int Con;
        public bool profCon = false;
        public int Int;
        public bool profInt = false;
        public bool profArcana = false;
        public bool expArcana = false;
        public int addArcana;
        public bool profHistory = false;
        public bool expHistory = false;
        public int addHistory;
        public bool profInvestigation = false;
        public bool expInvestigation = false;
        public int addInvestigation;
        public bool profNature = false;
        public bool expNature = false;
        public int addNature;
        public bool profReligion = false;
        public bool expReligion = false;
        public int addReligion;
        public int Wis;
        public bool profWis = false;
        public bool profAnimalHandling = false;
        public bool expAnimalHandling = false;
        public int addAnimalHandling;
        public bool profInsight = false;
        public bool expInsight = false;
        public int addInsight;
        public bool profMedicine = false;
        public bool expMedicine = false;
        public int addMedicine;
        public bool profPerception = false;
        public bool expPerception = false;
        public int addPerception;
        public bool profSurvival = false;
        public bool expSurvival = false;
        public int addSurvival;
        public int Cha;
        public bool profCha = false;
        public bool profDeception = false;
        public bool expDeception = false;
        public int addDeception;
        public bool profIntimidation = false;
        public bool expIntimidation = false;
        public int addIntimidation;
        public bool profPerformance = false;
        public bool expPerformance = false;
        public int addPerformance;
        public bool profPersuasion = false;
        public bool expPersuasion = false;
        public int addPersuasion;

        //methods

        /// <summary>
        /// converts a stat score into its modifier
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        public int ScoreToMod(int score)
        {
            return ((score - 10) / 2);
        }//end of ScoreToMod

    }//end of PlayerStats

}//end of DndCharacterApp.Objects