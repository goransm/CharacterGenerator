using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterLib
{
    public class Thief : Character
    {

        public Thief(string name, int armorRating = 60, string characterType = "thief") : base(name, armorRating)
        {
            HP = 100;
            Energy = 100;
            CharacterType = characterType;
            CharacterClass = "thief";
        }


        public override int Attack(ICharacter character)
        {
            var attackPower = Energy > 8 ? 8 : Energy;
            Energy -= attackPower;
            return character.Defend(attackPower);
        }
    }
}
