using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterLib
{
    public interface ICharacter
    {
        int Attack(ICharacter character);
        int Defend(int attackPower);
        string Move(string description);
    }
}
