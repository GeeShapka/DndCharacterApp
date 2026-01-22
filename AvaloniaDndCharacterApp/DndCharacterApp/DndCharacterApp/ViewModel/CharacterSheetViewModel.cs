using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCharacterApp;
using DndCharacterApp.Data;
using DndCharacterApp.Objects.Player;

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
		public ObservableCollection<Player_NonStatic> Players {  get; } = new ObservableCollection<Player_NonStatic>();
        public DbConnectionFactory dbcf;
        public SqliteDataBase db;

        //damage types for attacks section
        public List<string> DamageTypes { get { return Objects.Misc.DamageTypes.DamageTypeList; } }
		public string ComboAttackOneDamageType { get { return "smth"; } set { Player_Static.AttackOneDamageType = value ?? string.Empty; } }
		public string ComboAttackTwoDamageType { get { return "smth"; } set { Player_Static.AttackTwoDamageType = value ?? string.Empty; } }
		public string ComboAttackThreeDamageType { get { return "smth"; } set { Player_Static.AttackThreeDamageType = value ?? string.Empty; } }
		public string ComboAttackFourDamageType { get { return "smth"; } set { Player_Static.AttackFourDamageType = value ?? string.Empty; } }
		public string ComboAttackFiveDamageType { get { return "smth"; } set { Player_Static.AttackFiveDamageType = value ?? string.Empty; } }



        //constructor
        internal CharacterSheetViewModel()
        {
            dbcf = new DbConnectionFactory("Data Source=players.db");
            dbcf.Initialize();
            db = new SqliteDataBase(dbcf);
        }


        /// <summary>
        /// inserts or updates a player in the database
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task WriteToDb(Player_NonStatic p)
        {
            p.Id = await db.InsertAsync(p);
        }



        /// <summary>
        /// loads all players from the database
        /// </summary>
        /// <returns></returns>
        public async Task LoadAsync()
        {
            Players.Clear();
            var players = await db.GetAllAsync();

            foreach (Player_NonStatic c in Players)
                Players.Add(c);
        }


    }//end of CharacterSheetViewModel

}//end of DndCharacterApp.ViewModel