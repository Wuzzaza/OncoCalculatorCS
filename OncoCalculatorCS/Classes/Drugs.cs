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
        public enum CalculationMethod
        {BSA, AUC, PER_KG, FIXED};

        public string name { get; set; }
        public string description { get; set; }
        public double dose { get; set; }
        public CalculationMethod calculationMethod { get; set; }
        public double currentDose { get; set; }

        public Drug clone() {
            Drug thisDrugCopy = new Drug();
            thisDrugCopy.name = this.name;
            thisDrugCopy.description = this.description;
            thisDrugCopy.dose = this.dose;
            thisDrugCopy.currentDose = this.currentDose;
            thisDrugCopy.calculationMethod = this.calculationMethod;

            return thisDrugCopy;
        }
    }
}
