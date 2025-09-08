namespace DndCharacterApp
{
    partial class CharacterSheet
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCharacterXp = new Label();
            btnLevelUp = new Button();
            btnLevelDown = new Button();
            lblCharacterLevel = new Label();
            lblCharacterName = new Label();
            lblPlayerName = new Label();
            txtCharacterName = new TextBox();
            txtPlayerName = new TextBox();
            SuspendLayout();
            // 
            // lblCharacterXp
            // 
            lblCharacterXp.AutoSize = true;
            lblCharacterXp.Location = new Point(38, 24);
            lblCharacterXp.Name = "lblCharacterXp";
            lblCharacterXp.Size = new Size(107, 20);
            lblCharacterXp.TabIndex = 0;
            lblCharacterXp.Text = "lblCharacterXp";
            // 
            // btnLevelUp
            // 
            btnLevelUp.Location = new Point(188, 24);
            btnLevelUp.Name = "btnLevelUp";
            btnLevelUp.Size = new Size(94, 29);
            btnLevelUp.TabIndex = 1;
            btnLevelUp.Text = "/\\";
            btnLevelUp.UseVisualStyleBackColor = true;
            btnLevelUp.Click += btnLevelUp_Click;
            // 
            // btnLevelDown
            // 
            btnLevelDown.Location = new Point(188, 62);
            btnLevelDown.Name = "btnLevelDown";
            btnLevelDown.Size = new Size(94, 29);
            btnLevelDown.TabIndex = 2;
            btnLevelDown.Text = "\\/";
            btnLevelDown.UseVisualStyleBackColor = true;
            btnLevelDown.Click += btnXpDown_Click;
            // 
            // lblCharacterLevel
            // 
            lblCharacterLevel.AutoSize = true;
            lblCharacterLevel.Location = new Point(38, 71);
            lblCharacterLevel.Name = "lblCharacterLevel";
            lblCharacterLevel.Size = new Size(123, 20);
            lblCharacterLevel.TabIndex = 3;
            lblCharacterLevel.Text = "lblCharacterLevel";
            // 
            // lblCharacterName
            // 
            lblCharacterName.AutoSize = true;
            lblCharacterName.Location = new Point(38, 275);
            lblCharacterName.Name = "lblCharacterName";
            lblCharacterName.Size = new Size(129, 20);
            lblCharacterName.TabIndex = 4;
            lblCharacterName.Text = "lblCharacterName";
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoSize = true;
            lblPlayerName.Location = new Point(38, 325);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(106, 20);
            lblPlayerName.TabIndex = 5;
            lblPlayerName.Text = "lblPlayerName";
            // 
            // txtCharacterName
            // 
            txtCharacterName.Location = new Point(322, 275);
            txtCharacterName.Name = "txtCharacterName";
            txtCharacterName.Size = new Size(125, 27);
            txtCharacterName.TabIndex = 6;
            txtCharacterName.Text = "Character Name";
            txtCharacterName.TextChanged += txtCharacterName_TextChanged;
            // 
            // txtPlayerName
            // 
            txtPlayerName.Location = new Point(322, 325);
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.Size = new Size(125, 27);
            txtPlayerName.TabIndex = 7;
            txtPlayerName.Text = "Player Name";
            txtPlayerName.TextChanged += txtPlayerName_TextChanged;
            // 
            // CharacterSheet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 1033);
            Controls.Add(txtPlayerName);
            Controls.Add(txtCharacterName);
            Controls.Add(lblPlayerName);
            Controls.Add(lblCharacterName);
            Controls.Add(lblCharacterLevel);
            Controls.Add(btnLevelDown);
            Controls.Add(btnLevelUp);
            Controls.Add(lblCharacterXp);
            Name = "CharacterSheet";
            Text = "Form1";
            Load += CharacterSheet_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCharacterXp;
        private Button btnLevelUp;
        private Button btnLevelDown;
        private Label lblCharacterLevel;
        private Label lblCharacterName;
        private Label lblPlayerName;
        private TextBox txtCharacterName;
        private TextBox txtPlayerName;
    }
}
