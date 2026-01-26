using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
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
    internal partial class CharacterSheetViewModel
    {
		public ObservableCollection<Player_NonStatic> Players {  get; } = new ObservableCollection<Player_NonStatic>();
        private readonly IDataBase _db;
        public Player_NonStatic CurrentPlayer { get; }

        //damage types for attacks section
        public List<string> DamageTypes { get { return Objects.Misc.DamageTypes.DamageTypeList; } }
		public string ComboAttackOneDamageType { get { return "smth"; } set { Player_Static.AttackOneDamageType = value ?? string.Empty; } }
		public string ComboAttackTwoDamageType { get { return "smth"; } set { Player_Static.AttackTwoDamageType = value ?? string.Empty; } }
		public string ComboAttackThreeDamageType { get { return "smth"; } set { Player_Static.AttackThreeDamageType = value ?? string.Empty; } }
		public string ComboAttackFourDamageType { get { return "smth"; } set { Player_Static.AttackFourDamageType = value ?? string.Empty; } }
		public string ComboAttackFiveDamageType { get { return "smth"; } set { Player_Static.AttackFiveDamageType = value ?? string.Empty; } }

        private string _tempHp = "";
        public string TempHp
        {
            get { return _tempHp; }
            set
            {
                if(SetProperty(ref _tempHp, value))
                {
                    UpdateCurrentPlayer(value, "TempHp");
                }
            }
        }


        public bool? SleightOfHand { get; set; }



        //constructor
        internal CharacterSheetViewModel(DbConnectionFactory dbcf)
        {
            _db = new SqliteDataBase(dbcf);
            CurrentPlayer = new Player_NonStatic();
            CurrentPlayer.TimeCreated = DateTime.Now.Ticks;
        }


        /// <summary>
        /// inserts or updates a player in the database
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task WriteToDb(Player_NonStatic p)
        {
            await _db.InsertAsync(p);
        }



        /// <summary>
        /// loads all players from the database
        /// </summary>
        /// <returns></returns>
        public async Task LoadAsync()
        {
            Players.Clear();
            var players = await _db.GetAllAsync();

            foreach (Player_NonStatic c in Players)
                Players.Add(c);
        }







        /// <summary>
        /// takes an object and the field it should populate<br/>
        /// and validates it is correct. if it is it goes into the<br/>
        /// player class and retruns true. if something is wrong it<br/>
        /// returns false
        /// </summary>
        /// <param name="str"></param>
        /// <param name="field"></param>
        /// <returns>
        /// <b>True</b>: object inserted into player class
        /// <br/>
        /// <b>False</b>: object could not be inserted into player class
        /// </returns>
        public bool UpdateCurrentPlayer(string? str, string field)
        {
            bool noError = false;
            switch (field)
            {
                case "CharacterName":
                    if(str != null)
                    {
                        CurrentPlayer.CharacterName = (string)str;
                        noError = true;
                    }
                    break;
                case "TempHp":
                    int tempHp;
                    if(int.TryParse(str, out tempHp))
                    {
                        ClearErrors(nameof(TempHp));
                        CurrentPlayer.TempHp = tempHp;
                        noError = true;
                    }
                    else
                    {
                        AddError(nameof(TempHp), "");
                    }
                    break;
                default:
                    break;
            }
            return noError;
        }


    }//end of CharacterSheetViewModel

}//end of DndCharacterApp.ViewModel