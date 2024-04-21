using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._04._2024.Models
{
    internal class Wolf : Animal
    {
        private bool _isPrideLeader {  get; set; }
        private int _attackDamage {  get; set; }

        public bool IsPrideLeader
        {
           get { return _isPrideLeader; } set { _isPrideLeader = value;}
        }

        public int AttackDamage
        {
            get;
            set;
        }


        public Wolf(int avglifetime, string breed, int healtpoint, Gender gender, bool isleader, int attackdamage) : base(avglifetime, breed, healtpoint, gender)
        {
            IsPrideLeader = isleader;
            AttackDamage = attackdamage;
        }

    }
}
