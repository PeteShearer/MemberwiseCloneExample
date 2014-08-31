using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberwiseCloneExample
{
    public class Person
    {
        public string Name { get; set; }
        public Person Boss { get; set; }

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person copy = (Person)this.MemberwiseClone();

            if (this.Boss != null)
            {
                copy.Boss = this.Boss.DeepCopy();
            }

            return copy;
        }
    }
}
