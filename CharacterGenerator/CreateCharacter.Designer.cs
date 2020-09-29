namespace CharacterGenerator
{
    partial class CreateCharacter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.dropdownLabel = new System.Windows.Forms.Label();
            this.typeSelector = new System.Windows.Forms.ComboBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(11, 9);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(120, 15);
            this.title.TabIndex = 0;
            this.title.Text = "Create RPG Character";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(11, 47);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(94, 15);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Character name:";
            // 
            // nameInput
            // 
            this.nameInput.BackColor = System.Drawing.Color.Azure;
            this.nameInput.Location = new System.Drawing.Point(13, 65);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(185, 23);
            this.nameInput.TabIndex = 2;
            // 
            // dropdownLabel
            // 
            this.dropdownLabel.AutoSize = true;
            this.dropdownLabel.Location = new System.Drawing.Point(13, 119);
            this.dropdownLabel.Name = "dropdownLabel";
            this.dropdownLabel.Size = new System.Drawing.Size(119, 15);
            this.dropdownLabel.TabIndex = 3;
            this.dropdownLabel.Text = "Select character type:";
            // 
            // typeSelector
            // 
            this.typeSelector.FormattingEnabled = true;
            this.typeSelector.Items.AddRange(new object[] {
            "Wizard",
            "Code Wizard",
            "Warrior",
            "Keyboard Warrior",
            "Thief",
            "Pastor"});
            this.typeSelector.Location = new System.Drawing.Point(13, 137);
            this.typeSelector.Name = "typeSelector";
            this.typeSelector.Size = new System.Drawing.Size(185, 23);
            this.typeSelector.TabIndex = 4;
            // 
            // outputTextBox
            // 
            this.outputTextBox.BackColor = System.Drawing.Color.Black;
            this.outputTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.outputTextBox.Location = new System.Drawing.Point(368, 12);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(201, 147);
            this.outputTextBox.TabIndex = 5;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.createButton.Location = new System.Drawing.Point(206, 119);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(146, 40);
            this.createButton.TabIndex = 6;
            this.createButton.Text = "Create Character";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // CreateCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 388);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.typeSelector);
            this.Controls.Add(this.dropdownLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateCharacter";
            this.Text = "CreateCharacter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label dropdownLabel;
        private System.Windows.Forms.ComboBox typeSelector;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button createButton;
    }
}