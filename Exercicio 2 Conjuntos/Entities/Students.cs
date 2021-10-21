using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_2_Conjuntos.Entities
{
    class Students
    {
        public string Name { get; set; }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Students))
            {
                return false;
            }
            Students other = obj as Students;
            return Name.Equals(other.Name);
        }
    }
}
