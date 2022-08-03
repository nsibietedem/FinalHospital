using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfeanyiBankProblem.Models
{
    public class DrugAdministered:BaseEntity
    {
        public Pharmacist Pharmacist { get; set; }
        public List<DrugDosage> Drugs { get; set; }
    } 
}
