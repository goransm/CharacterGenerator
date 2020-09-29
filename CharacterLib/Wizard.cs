using System;

namespace CharacterLib
{
    public class Wizard : Character
    {
        public Wizard(string name, int armorRating = 40, string characterType = "wizard") : base(name, armorRating)
        {
            HP = 80;
            Energy = 120;
            CharacterType = characterType;
            CharacterClass = "wizard";
        }

        public override int Attack(ICharacter character)
        {
            var attackPower = Energy > 20 ? 20 : Energy;
            Energy -= attackPower;
            return character.Defend(attackPower);
        }
    }
}
