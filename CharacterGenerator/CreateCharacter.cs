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
using Microsoft.Data.SqlClient;

namespace CharacterGenerator
{
    public partial class CreateCharacter : Form
    {
        private string ConnectionString { get; }
        public CreateCharacter()
        {
            InitializeComponent();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "PC7414\\SQLEXPRESS";
            builder.InitialCatalog = "RPGCharacters";
            builder.IntegratedSecurity = true;
            ConnectionString = builder.ConnectionString;
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
                    SaveCharacter(prince);
                    
                }
            }

        }

        private void SaveCharacter(Character c)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                var sqlString = $"Insert into Character (name, type, hp, energy, armorrating) values({c.DbValues()})";
                connection.Open();
                var command = new SqlCommand(sqlString, connection);
                var adapter = new SqlDataAdapter();
                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
        }
    }
}
