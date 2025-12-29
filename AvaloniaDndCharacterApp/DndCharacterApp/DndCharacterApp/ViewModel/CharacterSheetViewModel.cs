using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCharacterApp;

namespace DndCharacterApp.ViewModel
{
    /*
	 * FILE : CharacterSheetViewModel.cs
	 * PROJECT : $safeprojectname$
	 * PROGRAMMER : George Shapka
	 * FIRST VERSION : 12/28/2025 9:08:42 PM
	 */
    internal class CharacterSheetViewModel
    {
		public List<string> DamageTypes { get { return Objects.DamageTypes.DamageTypeList; } }
		public string? ComboAttackOneDamageType { get { return "smth"; } }
		public string? ComboAttackTwoDamageType { get { return "smth"; } }
		public string? ComboAttackThreeDamageType { get { return "smth"; } }
		public string? ComboAttackFourDamageType { get { return "smth"; } }
		public string? ComboAttackFiveDamageType { get { return "smth"; } }
    }//end of CharacterSheetViewModel

}//end of DndCharacterApp.ViewModel