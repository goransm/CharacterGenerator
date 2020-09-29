using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterLib
{
    public class CodeWizard : Wizard
    {
        public CodeWizard(string name) : base(name, 60, "code wizard")
        {
            HP = 90;
            Energy = 110;
        }

        public override int Attack(ICharacter character)
        {
            // The code wizard can manipulate available energy
            Energy += 5;
            return base.Attack(character);
        }
    }
}
