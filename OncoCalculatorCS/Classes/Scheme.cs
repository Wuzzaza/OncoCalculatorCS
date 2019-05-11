using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OncoCalculatorCS.Classes
{
    [Serializable]
    public class Scheme
    {
        public string name { get; set; }
        public int intervalInDays { get; set; }
        public BindingList<Drug> drugsList { get; set; }

        public Scheme()
        {
            this.drugsList = new BindingList<Drug>();
        }

        
    }
}
