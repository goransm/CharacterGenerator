using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterLib
{
    public class Warrior : Character
    {
        public Warrior(string name, int armorRating = 80, string characterType = "warrior") : base(name, armorRating)
        {
            HP = 150;
            Energy = 100;

            CharacterType = characterType;
            CharacterClass = "warrior";
        }

        public override int Attack(ICharacter character)
        {
            var attackPower = Energy > 10 ? 10 : Energy;
            Energy -= attackPower;
            return character.Defend(attackPower);
        }
    }
}
