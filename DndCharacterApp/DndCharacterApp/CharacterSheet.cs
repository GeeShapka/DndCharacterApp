namespace DndCharacterApp
{
    public partial class CharacterSheet : Form
    {
        Character PlayerCharacter = new Character();

        public CharacterSheet()
        {
            InitializeComponent();
        }

        /// <summary>
        /// loads characterSheet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CharacterSheet_Load(object sender, EventArgs e)
        {
            lblCharacterLevel.Text = "1";
            lblCharacterXp.Text = "1";
        }


        /// <summary>
        /// takes character name from form and adds it to character
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCharacterName_TextChanged(Object sender, EventArgs e)
        {
            PlayerCharacter.CharacterName.Clear();//clear name
            foreach (char c in txtCharacterName.Text)//re-enter name
            {
                PlayerCharacter.CharacterName.Add(c);
            }

            string name = new string(PlayerCharacter.CharacterName.ToArray());//turn name into string
            lblCharacterName.Text = name;
        }//end of method

        /// <summary>
        /// takes player name from form and adds it to character
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {
            PlayerCharacter.PlayerName.Clear();//clear name
            foreach (char c in txtPlayerName.Text)//re-enter name
            {
                PlayerCharacter.PlayerName.Add(c);
            }

            string name = new string(PlayerCharacter.PlayerName.ToArray());//turn name into string
            lblPlayerName.Text = name;
        }//end of method

        /// <summary>
        /// adds a level to character
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXpUp_Click(object sender, EventArgs e)
        {
            int currentLevel = int.Parse(lblCharacterLevel.Text);
            if (currentLevel < 20)
            {
                currentLevel++;
            }

            int currentXp = Experience.LevelToXp(currentLevel);
            PlayerCharacter.Xp = currentXp;

            lblCharacterXp.Text = PlayerCharacter.Xp.ToString();
            lblCharacterLevel.Text = currentLevel.ToString();

            return;
        }

        /// <summary>
        /// removes a level from character
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXpDown_Click(object sender, EventArgs e)
        {
            int currentLevel = int.Parse(lblCharacterLevel.Text);
            if (currentLevel > 1)
            {
                currentLevel--;
            }

            int currentXp = Experience.LevelToXp(currentLevel);
            PlayerCharacter.Xp = currentXp;

            lblCharacterXp.Text = PlayerCharacter.Xp.ToString();
            lblCharacterLevel.Text = currentLevel.ToString();

            return;
        }//end of method

    }//end of class
}
