using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.gyak_BodnarPeter_ppy8uy.Entities
{
    public enum Gender
    {
        Male=1,
        Female=2
    }
    public class Person
    {
        public int BirthYear { get; set; }
        public Gender Gender { get; set; }
        public int NbrOfChildren { get; set; }
        public bool IsAlive { get; set; }

        public Person()
        {
            IsAlive = true;
        }
        public class BirthProbability
        {
            public int BirthYear { get; set; }
            public int NbrOfChildren { get; set; }
            public double BProbability { get; set; }
        }
        public class DeathProbability
        {
            public Gender Gender { get; set; }
            public int BirthYear { get; set; }
            public double DProbability { get; set; }
        }
    }
}
