using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterLib
{
    public class KeyboardWarrior : Warrior
    {
        public KeyboardWarrior(string name) : base(name, 200, "keyboard warrior")
        {
            HP = 200;
            Energy = 200;
        }

        public override int Attack(ICharacter character)
        {
            // While the keyboard warrior is hard to kill, (s)he doesn't deal much damage either.
            var attackPower = Energy > 1 ? 1 : Energy;
            return character.Defend(attackPower);
        }
    }
}
