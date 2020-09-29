using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.IO;

namespace CharacterLib
{
    public abstract class Character : ICharacter
    {
        string Name { get; }
        protected int HP { get; set; }
        protected int Energy { get; set; }
        protected int ArmorRating { get; }
        protected string CharacterType { get; set; }
        protected string CharacterClass { get; set; }

        public Character()
        {
            Name = "Chuck Norris";
            HP = 100;
            Energy = 100;
            ArmorRating = 100;
        }

        public Character (string name, int armorRating)
        {
            Name = name;
            ArmorRating = armorRating;
        }

        private double distance()
        {
            return 10 * (HP / 100) * (Energy / 100);
        }

        public int Defend(int attackPower)
        {
            var damage = (int)attackPower / ArmorRating;

            if(damage > this.HP)
            {
                damage = this.HP;
            }

            this.HP -= damage;
            return damage;
        }

        public abstract int Attack(ICharacter character);
        public string Move(string direction) {
            return $"{Name} moves {distance()} meters {direction}";
        }

        public override string ToString()
        {
            return $"Name: {Name}{Environment.NewLine}Type: {CharacterType}{Environment.NewLine}HP: {HP}{Environment.NewLine}Energy: {Energy}{Environment.NewLine}ArmorRating: {ArmorRating}";
        }

        public void saveToTextFile(TextWriter writer)
        {
            writer.WriteLine(this.ToString());
            writer.WriteLine("");

        }


        
    }
}
