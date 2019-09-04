using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OncoCalculatorCS.Classes
{
    [Serializable]
    public class Patient
    {
        public enum Gender
        {M, F}

        public string name { get; set; }
        public string description{ get; set; }
        public int weight { get; set; }
        public int height { get; set; }
        public int age { get; set; }
        public Gender gender { get; set; }
        public Scheme scheme { get; set; }


    }
}
