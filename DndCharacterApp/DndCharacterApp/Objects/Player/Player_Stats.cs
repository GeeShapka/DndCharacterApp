using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharacterApp.Objects.Player
{
    /*
	 * FILE : Player_Stats.cs
	 * PROJECT : DndCharacterApp
	 * PROGRAMMER : George Shapka
	 * FIRST VERSION : 10/13/2025 8:39:40 PM
	 */
    internal partial class Player
    {
        //methods

        /// <summary>
        /// updates the Strength mod and associated skills
        /// </summary>
        public void UpdateStr()
		{
			Mods.Str = PlayerMods.ScoreToMod(ScoreStr);
			if (Mods.profStr == true) { Mods.Str += Prof; }

			Mods.Athletics = Mods.Str;
			if (Mods.profAthletics == true) { Mods.Athletics += Prof; }
			if (Mods.expAthletics == true) { Mods.Athletics += Prof; }
		}//end of UpdateStr



        /// <summary>
        /// Updates the Dexterity mod and associated skills
        /// </summary>
        public void UpdateDex()
        {
            Mods.Dex = PlayerMods.ScoreToMod(ScoreDex);
            if (Mods.profDex == true) { Mods.Dex += Prof; }

            Mods.Acrobatics = Mods.Dex;
            if (Mods.profAcrobatics == true) { Mods.Acrobatics += Prof; }
            if (Mods.expAcrobatics == true) { Mods.Acrobatics += Prof; }

            Mods.SleightOfHand = Mods.Dex;
            if (Mods.profSleightOfHand == true) { Mods.SleightOfHand += Prof; }
            if (Mods.expSleightOfHand == true) { Mods.SleightOfHand += Prof; }

            Mods.Stealth = Mods.Dex;
            if (Mods.profStealth == true) { Mods.Stealth += Prof; }
            if (Mods.expStealth == true) { Mods.Stealth += Prof; }
        }//end of UpdateDex



        /// <summary>
        /// Updates the Constitution mod
        /// </summary>
        public void UpdateCon()
        {
            Mods.Con = PlayerMods.ScoreToMod(ScoreCon);
            if (Mods.profCon == true) { Mods.Con += Prof; }
            // No skills directly tied to Con
        }//end of UpdateCon



        /// <summary>
        /// Updates the Intelligence mod and associated skills
        /// </summary>
        public void UpdateInt()
        {
            Mods.Int = PlayerMods.ScoreToMod(ScoreInt);
            if (Mods.profInt == true) { Mods.Int += Prof; }

            Mods.Arcana = Mods.Int;
            if (Mods.profArcana == true) { Mods.Arcana += Prof; }
            if (Mods.expArcana == true) { Mods.Arcana += Prof; }

            Mods.History = Mods.Int;
            if (Mods.profHistory == true) { Mods.History += Prof; }
            if (Mods.expHistory == true) { Mods.History += Prof; }

            Mods.Investigation = Mods.Int;
            if (Mods.profInvestigation == true) { Mods.Investigation += Prof; }
            if (Mods.expInvestigation == true) { Mods.Investigation += Prof; }

            Mods.Nature = Mods.Int;
            if (Mods.profNature == true) { Mods.Nature += Prof; }
            if (Mods.expNature == true) { Mods.Nature += Prof; }

            Mods.Religion = Mods.Int;
            if (Mods.profReligion == true) { Mods.Religion += Prof; }
            if (Mods.expReligion == true) { Mods.Religion += Prof; }
        }//end of UpdateInt



        /// <summary>
        /// Updates the Wisdom mod and associated skills
        /// </summary>
        public void UpdateWis()
        {
            Mods.Wis = PlayerMods.ScoreToMod(ScoreWis);
            if (Mods.profWis == true) { Mods.Wis += Prof; }

            Mods.AnimalHandling = Mods.Wis;
            if (Mods.profAnimalHandling == true) { Mods.AnimalHandling += Prof; }
            if (Mods.expAnimalHandling == true) { Mods.AnimalHandling += Prof; }

            Mods.Insight = Mods.Wis;
            if (Mods.profInsight == true) { Mods.Insight += Prof; }
            if (Mods.expInsight == true) { Mods.Insight += Prof; }

            Mods.Medicine = Mods.Wis;
            if (Mods.profMedicine == true) { Mods.Medicine += Prof; }
            if (Mods.expMedicine == true) { Mods.Medicine += Prof; }

            Mods.Perception = Mods.Wis;
            if (Mods.profPerception == true) { Mods.Perception += Prof; }
            if (Mods.expPerception == true) { Mods.Perception += Prof; }

            Mods.Survival = Mods.Wis;
            if (Mods.profSurvival == true) { Mods.Survival += Prof; }
            if (Mods.expSurvival == true) { Mods.Survival += Prof; }
        }//end of UpdateWis



        /// <summary>
        /// Updates the Charisma mod and associated skills
        /// </summary>
        public void UpdateCha()
        {
            Mods.Cha = PlayerMods.ScoreToMod(ScoreCha);
            if (Mods.profCha == true) { Mods.Cha += Prof; }

            Mods.Deception = Mods.Cha;
            if (Mods.profDeception == true) { Mods.Deception += Prof; }
            if (Mods.expDeception == true) { Mods.Deception += Prof; }

            Mods.Intimidation = Mods.Cha;
            if (Mods.profIntimidation == true) { Mods.Intimidation += Prof; }
            if (Mods.expIntimidation == true) { Mods.Intimidation += Prof; }

            Mods.Performance = Mods.Cha;
            if (Mods.profPerformance == true) { Mods.Performance += Prof; }
            if (Mods.expPerformance == true) { Mods.Performance += Prof; }

            Mods.Persuasion = Mods.Cha;
            if (Mods.profPersuasion == true) { Mods.Persuasion += Prof; }
            if (Mods.expPersuasion == true) { Mods.Persuasion += Prof; }
        }//end of UpdateCha

    }//end of Player

}//end of DndCharacterApp.Objects.Player