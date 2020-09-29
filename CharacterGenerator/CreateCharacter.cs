using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

using CharacterLib;


namespace CharacterGenerator
{
    public partial class CreateCharacter : Form
    {
        public CreateCharacter()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var characterName = nameInput.Text;
            var characterType = typeSelector.SelectedItem;
            outputTextBox.Text = $"Hello Creator!\n{characterName}\n{characterType}";
            if( characterName == "")
            {
                outputTextBox.Text = "Cannot create a nameless character, unless its name used to be Prince";
            } else
            {
                Character prince = null;
                switch (characterType)
                {
                    case "Wizard":
                        prince = new Wizard(characterName);
                        break;
                    case "Code Wizard":
                        prince = new CodeWizard(characterName);
                        break;
                    case "Warrior":
                        prince = new Warrior(characterName);
                        break;
                    case "Keyboard Warrior":
                        prince = new KeyboardWarrior(characterName);
                        break;
                    case "Thief":
                        prince = new Thief(characterName);
                        break;
                    case "Pastor":
                        prince = new Pastor(characterName);
                        break;
                    default:
                        outputTextBox.Text = "Could not create a character, because of missing type.";
                        break;
                       

                }
                if (prince != null)
                {
                    outputTextBox.Text = prince.ToString();
                    using (StreamWriter w = File.AppendText("characters.txt"))
                    {
                    prince.saveToTextFile(w);
                    }
                }
            }

        }
    }
}
