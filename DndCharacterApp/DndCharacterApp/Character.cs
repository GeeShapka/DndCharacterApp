//first version: 07/09/25
//programmer: George Shapka
namespace DndCharacterApp
{
	internal class Character
	{
        //Variables
        public List<char> CharacterName = new List<char>();

        public List<char> PlayerName = new List<char>();

        public int Xp { get { return (_xp); } set { _xp = value; } }
		private int _xp;





		//Methods
		
		/// <summary>
		/// adds xp to character
		/// </summary>
		/// <param name="xp"></param>
		public void AddXp(int xp)
		{
			_xp += xp;
		}//end of method

		public void AddCharacterNameLetter(char letter)
		{
			PlayerName.Add(letter);
		}
	}
}
