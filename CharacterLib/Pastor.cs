using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterLib
{
    public class Pastor : Thief
    {
        public Pastor(string name) : base(name, 50, "pastor")
        {
            HP = 90;
            Energy = 110;
        }

        public override int Attack(ICharacter character)
        {
            var attackPower = Energy > 5 ? 5 : Energy;
            var damage = character.Defend(attackPower);
            // The pastor gains HP from the victims
            HP += damage;
            return damage;
        }
    }
}
