using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalCompoundLibray.Models
{
    public class ChemicalCompoundModel
    {
        public string ChemicalName { get; set; }
        public string MolecularFormula { get; set; }
        public float MolecularWeight { get; set; }
        public float MeltingPoint { get; set; }
        public float NormalBoilingPoint { get; set; }
        public float NormalVaporDensity { get; set; }
        public float CriticalTemperature { get; set; }
        public float CriticalPressure { get; set; }
        public float CriticalDensity { get; set; }
        public float ReferenceTemp { get; set; }
        public float ReferencePressure { get; set; }

    }
}
