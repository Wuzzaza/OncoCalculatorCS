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

        public Scheme clone() {
            Scheme thisSchemeCopy = new Scheme();
            thisSchemeCopy.name = this.name;
            thisSchemeCopy.intervalInDays = this.intervalInDays;
            thisSchemeCopy.drugsList = new BindingList<Drug>();
            foreach (Drug drug in this.drugsList)
            {
                thisSchemeCopy.drugsList.Add(drug.clone());
            }

            return thisSchemeCopy;
        }

        public override string ToString()
        {
            return this.name;
        }

        public string drugListText()
        {
            StringBuilder text = new StringBuilder(name);
            foreach (Drug drug in drugsList)
            {
                text.Append(drug.name);
            } 
            return text.ToString();
        }
    }

    
}
