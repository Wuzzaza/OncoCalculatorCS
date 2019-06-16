using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OncoCalculatorCS.Classes
{
    [Serializable]
    public class Drug
    {
        public string name { get; set; }
        public string description { get; set; }
        public int doseBSA { get; set; }
        public int AUC { get; set; }
        public int currentDose { get; set; }
        public bool constantDose { get; set; }

        public Drug makeCopy() {
            Drug thisDrugCopy = new Drug();
            thisDrugCopy.name = this.name;
            thisDrugCopy.description = this.description;
            thisDrugCopy.doseBSA = this.doseBSA;
            thisDrugCopy.currentDose = this.currentDose;
            thisDrugCopy.AUC = this.AUC;

            return thisDrugCopy;
        }
    }
}
