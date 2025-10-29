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
        /// Updates the Strength modifier and associated skills.
        /// </summary>
        public static void UpdateStr()
        {
            PlayerMods.Str = PlayerMods.ScoreToMod(ScoreStr);

            PlayerMods.StrSave = PlayerMods.Str;
            if (PlayerMods.profStr) PlayerMods.StrSave += Prof;
            if (PlayerMods.expStr) PlayerMods.StrSave += 2 * Prof;
            PlayerMods.StrSave += PlayerMods.addStr;

            PlayerMods.Athletics = PlayerMods.Str;
            if (PlayerMods.profAthletics) PlayerMods.Athletics += Prof;
            if (PlayerMods.expAthletics) PlayerMods.Athletics += 2 * Prof;
            PlayerMods.Athletics += PlayerMods.addAthletics;
        }//end of UpdateStr


        /// <summary>
        /// Updates the Dexterity modifier and associated skills.
        /// </summary>
        public static void UpdateDex()
        {
            PlayerMods.Dex = PlayerMods.ScoreToMod(ScoreDex);

            PlayerMods.DexSave = PlayerMods.Dex;
            if (PlayerMods.profDex) PlayerMods.DexSave += Prof;
            if (PlayerMods.expDex) PlayerMods.DexSave += 2 * Prof;
            PlayerMods.DexSave += PlayerMods.addDex;

            PlayerMods.Acrobatics = PlayerMods.Dex;
            if (PlayerMods.profAcrobatics) PlayerMods.Acrobatics += Prof;
            if (PlayerMods.expAcrobatics) PlayerMods.Acrobatics += 2 * Prof;
            PlayerMods.Acrobatics += PlayerMods.addAcrobatics;

            PlayerMods.SleightOfHand = PlayerMods.Dex;
            if (PlayerMods.profSleightOfHand) PlayerMods.SleightOfHand += Prof;
            if (PlayerMods.expSleightOfHand) PlayerMods.SleightOfHand += 2 * Prof;
            PlayerMods.SleightOfHand += PlayerMods.addSleightOfHand;

            PlayerMods.Stealth = PlayerMods.Dex;
            if (PlayerMods.profStealth) PlayerMods.Stealth += Prof;
            if (PlayerMods.expStealth) PlayerMods.Stealth += 2 * Prof;
            PlayerMods.Stealth += PlayerMods.addStealth;
        }//end of UpdateDex


        /// <summary>
        /// Updates the Constitution modifier.
        /// </summary>
        public static void UpdateCon()
        {
            PlayerMods.Con = PlayerMods.ScoreToMod(ScoreCon);

            PlayerMods.ConSave = PlayerMods.Con;
            if (PlayerMods.profCon) PlayerMods.ConSave += Prof;
            if (PlayerMods.expCon) PlayerMods.ConSave += 2 * Prof;
            PlayerMods.ConSave += PlayerMods.addCon;
        }//end of UpdateCon


        /// <summary>
        /// Updates the Intelligence modifier and associated skills.
        /// </summary>
        public static void UpdateInt()
        {
            PlayerMods.Int = PlayerMods.ScoreToMod(ScoreInt);

            PlayerMods.IntSave = PlayerMods.Int;
            if (PlayerMods.profInt) PlayerMods.IntSave += Prof;
            if (PlayerMods.expInt) PlayerMods.IntSave += 2 * Prof;
            PlayerMods.IntSave += PlayerMods.addInt;

            PlayerMods.Arcana = PlayerMods.Int;
            if (PlayerMods.profArcana) PlayerMods.Arcana += Prof;
            if (PlayerMods.expArcana) PlayerMods.Arcana += 2 * Prof;
            PlayerMods.Arcana += PlayerMods.addArcana;

            PlayerMods.History = PlayerMods.Int;
            if (PlayerMods.profHistory) PlayerMods.History += Prof;
            if (PlayerMods.expHistory) PlayerMods.History += 2 * Prof;
            PlayerMods.History += PlayerMods.addHistory;

            PlayerMods.Investigation = PlayerMods.Int;
            if (PlayerMods.profInvestigation) PlayerMods.Investigation += Prof;
            if (PlayerMods.expInvestigation) PlayerMods.Investigation += 2 * Prof;
            PlayerMods.Investigation += PlayerMods.addInvestigation;

            PlayerMods.Nature = PlayerMods.Int;
            if (PlayerMods.profNature) PlayerMods.Nature += Prof;
            if (PlayerMods.expNature) PlayerMods.Nature += 2 * Prof;
            PlayerMods.Nature += PlayerMods.addNature;

            PlayerMods.Religion = PlayerMods.Int;
            if (PlayerMods.profReligion) PlayerMods.Religion += Prof;
            if (PlayerMods.expReligion) PlayerMods.Religion += 2 * Prof;
            PlayerMods.Religion += PlayerMods.addReligion;
        }//end of UpdateInt


        /// <summary>
        /// Updates the Wisdom modifier and associated skills.
        /// </summary>
        public static void UpdateWis()
        {
            PlayerMods.Wis = PlayerMods.ScoreToMod(ScoreWis);

            PlayerMods.WisSave = PlayerMods.Wis;
            if (PlayerMods.profWis) PlayerMods.WisSave += Prof;
            if (PlayerMods.expWis) PlayerMods.WisSave += 2 * Prof;
            PlayerMods.WisSave += PlayerMods.addWis;

            PlayerMods.AnimalHandling = PlayerMods.Wis;
            if (PlayerMods.profAnimalHandling) PlayerMods.AnimalHandling += Prof;
            if (PlayerMods.expAnimalHandling) PlayerMods.AnimalHandling += 2 * Prof;
            PlayerMods.AnimalHandling += PlayerMods.addAnimalHandling;

            PlayerMods.Insight = PlayerMods.Wis;
            if (PlayerMods.profInsight) PlayerMods.Insight += Prof;
            if (PlayerMods.expInsight) PlayerMods.Insight += 2 * Prof;
            PlayerMods.Insight += PlayerMods.addInsight;

            PlayerMods.Medicine = PlayerMods.Wis;
            if (PlayerMods.profMedicine) PlayerMods.Medicine += Prof;
            if (PlayerMods.expMedicine) PlayerMods.Medicine += 2 * Prof;
            PlayerMods.Medicine += PlayerMods.addMedicine;

            PlayerMods.Perception = PlayerMods.Wis;
            if (PlayerMods.profPerception) PlayerMods.Perception += Prof;
            if (PlayerMods.expPerception) PlayerMods.Perception += 2 * Prof;
            PlayerMods.Perception += PlayerMods.addPerception;

            PlayerMods.Survival = PlayerMods.Wis;
            if (PlayerMods.profSurvival) PlayerMods.Survival += Prof;
            if (PlayerMods.expSurvival) PlayerMods.Survival += 2 * Prof;
            PlayerMods.Survival += PlayerMods.addSurvival;
        }//end of UpdateWis


        /// <summary>
        /// Updates the Charisma modifier and associated skills.
        /// </summary>
        public static void UpdateCha()
        {
            PlayerMods.Cha = PlayerMods.ScoreToMod(ScoreCha);

            PlayerMods.ChaSave = PlayerMods.Cha;
            if (PlayerMods.profCha) PlayerMods.ChaSave += Prof;
            if (PlayerMods.expCha) PlayerMods.ChaSave += 2 * Prof;
            PlayerMods.ChaSave += PlayerMods.addCha;

            PlayerMods.Deception = PlayerMods.Cha;
            if (PlayerMods.profDeception) PlayerMods.Deception += Prof;
            if (PlayerMods.expDeception) PlayerMods.Deception += 2 * Prof;
            PlayerMods.Deception += PlayerMods.addDeception;

            PlayerMods.Intimidation = PlayerMods.Cha;
            if (PlayerMods.profIntimidation) PlayerMods.Intimidation += Prof;
            if (PlayerMods.expIntimidation) PlayerMods.Intimidation += 2 * Prof;
            PlayerMods.Intimidation += PlayerMods.addIntimidation;

            PlayerMods.Performance = PlayerMods.Cha;
            if (PlayerMods.profPerformance) PlayerMods.Performance += Prof;
            if (PlayerMods.expPerformance) PlayerMods.Performance += 2 * Prof;
            PlayerMods.Performance += PlayerMods.addPerformance;

            PlayerMods.Persuasion = PlayerMods.Cha;
            if (PlayerMods.profPersuasion) PlayerMods.Persuasion += Prof;
            if (PlayerMods.expPersuasion) PlayerMods.Persuasion += 2 * Prof;
            PlayerMods.Persuasion += PlayerMods.addPersuasion;
        }//end of UpdateCha



        /// <summary>
        /// Updates all ability and skill modifiers.
        /// </summary>
        public static void UpdateAll()
        {
            UpdateStr();
            UpdateDex();
            UpdateCon();
            UpdateInt();
            UpdateWis();
            UpdateCha();
        }//end of UpdateAll

    }//end of Player

}//end of DndCharacterApp.Objects.Player