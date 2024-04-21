using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._04._2024.Models
{
    internal class Elephant : Animal
    {
        private double _weight {  get; set; }

        public double Weight
        {

            get;

            set;
        }
        private bool _istranied;

        public bool IsTrained
        {
            get;
            set;
        }


        public Elephant(int avglifetime, string breed, int healtpoint, Gender gender, double weight, bool istrained) : base(avglifetime, breed, healtpoint, gender)
        {
            Weight = weight;
            IsTrained = istrained;
        }

    }
}
