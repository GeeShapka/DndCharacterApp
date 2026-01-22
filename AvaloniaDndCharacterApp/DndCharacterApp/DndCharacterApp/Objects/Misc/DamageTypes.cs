using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharacterApp.Objects.Misc
{
    /*
	 * FILE : DamageTypes.cs
	 * PROJECT : $safeprojectname$
	 * PROGRAMMER : George Shapka
	 * FIRST VERSION : 12/28/2025 9:07:15 PM
	 */
    internal class DamageTypes
    {
        public static List<string> DamageTypeList { get; } = new List<string>
        {
            "Acid",
            "Bludgeoning",
            "Cold",
            "Fire",
            "Force",
            "Lightning",
            "Necrotic",
            "Piercing",
            "Poison",
            "Psychic",
            "Radiant",
            "Slashing",
            "Thunder"
        };

    }//end of DamageTypes

}//end of DndCharacterApp.Objects