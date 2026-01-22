using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    internal partial class Player_Static
    {
        //methods

        /// <summary>
        /// Updates the Strength modifier and associated skills.
        /// </summary>
        public static void UpdateStr()
        {
            PlayerMods_Static.Str = PlayerMods_Static.ScoreToMod(ScoreStr);

            PlayerMods_Static.StrSave = PlayerMods_Static.Str;
            if (PlayerMods_Static.profStr) PlayerMods_Static.StrSave += Prof;
            if (PlayerMods_Static.expStr) PlayerMods_Static.StrSave += 2 * Prof;
            PlayerMods_Static.StrSave += PlayerMods_Static.addStr;

            PlayerMods_Static.Athletics = PlayerMods_Static.Str;
            if (PlayerMods_Static.profAthletics) PlayerMods_Static.Athletics += Prof;
            if (PlayerMods_Static.expAthletics) PlayerMods_Static.Athletics += 2 * Prof;
            PlayerMods_Static.Athletics += PlayerMods_Static.addAthletics;
        }//end of UpdateStr


        /// <summary>
        /// Updates the Dexterity modifier and associated skills.
        /// </summary>
        public static void UpdateDex()
        {
            PlayerMods_Static.Dex = PlayerMods_Static.ScoreToMod(ScoreDex);

            PlayerMods_Static.DexSave = PlayerMods_Static.Dex;
            if (PlayerMods_Static.profDex) PlayerMods_Static.DexSave += Prof;
            if (PlayerMods_Static.expDex) PlayerMods_Static.DexSave += 2 * Prof;
            PlayerMods_Static.DexSave += PlayerMods_Static.addDex;

            PlayerMods_Static.Acrobatics = PlayerMods_Static.Dex;
            if (PlayerMods_Static.profAcrobatics) PlayerMods_Static.Acrobatics += Prof;
            if (PlayerMods_Static.expAcrobatics) PlayerMods_Static.Acrobatics += 2 * Prof;
            PlayerMods_Static.Acrobatics += PlayerMods_Static.addAcrobatics;

            PlayerMods_Static.SleightOfHand = PlayerMods_Static.Dex;
            if (PlayerMods_Static.profSleightOfHand) PlayerMods_Static.SleightOfHand += Prof;
            if (PlayerMods_Static.expSleightOfHand) PlayerMods_Static.SleightOfHand += 2 * Prof;
            PlayerMods_Static.SleightOfHand += PlayerMods_Static.addSleightOfHand;

            PlayerMods_Static.Stealth = PlayerMods_Static.Dex;
            if (PlayerMods_Static.profStealth) PlayerMods_Static.Stealth += Prof;
            if (PlayerMods_Static.expStealth) PlayerMods_Static.Stealth += 2 * Prof;
            PlayerMods_Static.Stealth += PlayerMods_Static.addStealth;
        }//end of UpdateDex


        /// <summary>
        /// Updates the Constitution modifier.
        /// </summary>
        public static void UpdateCon()
        {
            PlayerMods_Static.Con = PlayerMods_Static.ScoreToMod(ScoreCon);

            PlayerMods_Static.ConSave = PlayerMods_Static.Con;
            if (PlayerMods_Static.profCon) PlayerMods_Static.ConSave += Prof;
            if (PlayerMods_Static.expCon) PlayerMods_Static.ConSave += 2 * Prof;
            PlayerMods_Static.ConSave += PlayerMods_Static.addCon;
        }//end of UpdateCon


        /// <summary>
        /// Updates the Intelligence modifier and associated skills.
        /// </summary>
        public static void UpdateInt()
        {
            PlayerMods_Static.Int = PlayerMods_Static.ScoreToMod(ScoreInt);

            PlayerMods_Static.IntSave = PlayerMods_Static.Int;
            if (PlayerMods_Static.profInt) PlayerMods_Static.IntSave += Prof;
            if (PlayerMods_Static.expInt) PlayerMods_Static.IntSave += 2 * Prof;
            PlayerMods_Static.IntSave += PlayerMods_Static.addInt;

            PlayerMods_Static.Arcana = PlayerMods_Static.Int;
            if (PlayerMods_Static.profArcana) PlayerMods_Static.Arcana += Prof;
            if (PlayerMods_Static.expArcana) PlayerMods_Static.Arcana += 2 * Prof;
            PlayerMods_Static.Arcana += PlayerMods_Static.addArcana;

            PlayerMods_Static.History = PlayerMods_Static.Int;
            if (PlayerMods_Static.profHistory) PlayerMods_Static.History += Prof;
            if (PlayerMods_Static.expHistory) PlayerMods_Static.History += 2 * Prof;
            PlayerMods_Static.History += PlayerMods_Static.addHistory;

            PlayerMods_Static.Investigation = PlayerMods_Static.Int;
            if (PlayerMods_Static.profInvestigation) PlayerMods_Static.Investigation += Prof;
            if (PlayerMods_Static.expInvestigation) PlayerMods_Static.Investigation += 2 * Prof;
            PlayerMods_Static.Investigation += PlayerMods_Static.addInvestigation;

            PlayerMods_Static.Nature = PlayerMods_Static.Int;
            if (PlayerMods_Static.profNature) PlayerMods_Static.Nature += Prof;
            if (PlayerMods_Static.expNature) PlayerMods_Static.Nature += 2 * Prof;
            PlayerMods_Static.Nature += PlayerMods_Static.addNature;

            PlayerMods_Static.Religion = PlayerMods_Static.Int;
            if (PlayerMods_Static.profReligion) PlayerMods_Static.Religion += Prof;
            if (PlayerMods_Static.expReligion) PlayerMods_Static.Religion += 2 * Prof;
            PlayerMods_Static.Religion += PlayerMods_Static.addReligion;
        }//end of UpdateInt


        /// <summary>
        /// Updates the Wisdom modifier and associated skills.
        /// </summary>
        public static void UpdateWis()
        {
            PlayerMods_Static.Wis = PlayerMods_Static.ScoreToMod(ScoreWis);

            PlayerMods_Static.WisSave = PlayerMods_Static.Wis;
            if (PlayerMods_Static.profWis) PlayerMods_Static.WisSave += Prof;
            if (PlayerMods_Static.expWis) PlayerMods_Static.WisSave += 2 * Prof;
            PlayerMods_Static.WisSave += PlayerMods_Static.addWis;

            PlayerMods_Static.AnimalHandling = PlayerMods_Static.Wis;
            if (PlayerMods_Static.profAnimalHandling) PlayerMods_Static.AnimalHandling += Prof;
            if (PlayerMods_Static.expAnimalHandling) PlayerMods_Static.AnimalHandling += 2 * Prof;
            PlayerMods_Static.AnimalHandling += PlayerMods_Static.addAnimalHandling;

            PlayerMods_Static.Insight = PlayerMods_Static.Wis;
            if (PlayerMods_Static.profInsight) PlayerMods_Static.Insight += Prof;
            if (PlayerMods_Static.expInsight) PlayerMods_Static.Insight += 2 * Prof;
            PlayerMods_Static.Insight += PlayerMods_Static.addInsight;

            PlayerMods_Static.Medicine = PlayerMods_Static.Wis;
            if (PlayerMods_Static.profMedicine) PlayerMods_Static.Medicine += Prof;
            if (PlayerMods_Static.expMedicine) PlayerMods_Static.Medicine += 2 * Prof;
            PlayerMods_Static.Medicine += PlayerMods_Static.addMedicine;

            PlayerMods_Static.Perception = PlayerMods_Static.Wis;
            if (PlayerMods_Static.profPerception) PlayerMods_Static.Perception += Prof;
            if (PlayerMods_Static.expPerception) PlayerMods_Static.Perception += 2 * Prof;
            PlayerMods_Static.Perception += PlayerMods_Static.addPerception;

            PlayerMods_Static.Survival = PlayerMods_Static.Wis;
            if (PlayerMods_Static.profSurvival) PlayerMods_Static.Survival += Prof;
            if (PlayerMods_Static.expSurvival) PlayerMods_Static.Survival += 2 * Prof;
            PlayerMods_Static.Survival += PlayerMods_Static.addSurvival;
        }//end of UpdateWis


        /// <summary>
        /// Updates the Charisma modifier and associated skills.
        /// </summary>
        public static void UpdateCha()
        {
            PlayerMods_Static.Cha = PlayerMods_Static.ScoreToMod(ScoreCha);

            PlayerMods_Static.ChaSave = PlayerMods_Static.Cha;
            if (PlayerMods_Static.profCha) PlayerMods_Static.ChaSave += Prof;
            if (PlayerMods_Static.expCha) PlayerMods_Static.ChaSave += 2 * Prof;
            PlayerMods_Static.ChaSave += PlayerMods_Static.addCha;

            PlayerMods_Static.Deception = PlayerMods_Static.Cha;
            if (PlayerMods_Static.profDeception) PlayerMods_Static.Deception += Prof;
            if (PlayerMods_Static.expDeception) PlayerMods_Static.Deception += 2 * Prof;
            PlayerMods_Static.Deception += PlayerMods_Static.addDeception;

            PlayerMods_Static.Intimidation = PlayerMods_Static.Cha;
            if (PlayerMods_Static.profIntimidation) PlayerMods_Static.Intimidation += Prof;
            if (PlayerMods_Static.expIntimidation) PlayerMods_Static.Intimidation += 2 * Prof;
            PlayerMods_Static.Intimidation += PlayerMods_Static.addIntimidation;

            PlayerMods_Static.Performance = PlayerMods_Static.Cha;
            if (PlayerMods_Static.profPerformance) PlayerMods_Static.Performance += Prof;
            if (PlayerMods_Static.expPerformance) PlayerMods_Static.Performance += 2 * Prof;
            PlayerMods_Static.Performance += PlayerMods_Static.addPerformance;

            PlayerMods_Static.Persuasion = PlayerMods_Static.Cha;
            if (PlayerMods_Static.profPersuasion) PlayerMods_Static.Persuasion += Prof;
            if (PlayerMods_Static.expPersuasion) PlayerMods_Static.Persuasion += 2 * Prof;
            PlayerMods_Static.Persuasion += PlayerMods_Static.addPersuasion;
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