using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._04._2024.Models
{
    public abstract class Animal
    {

        private int _avgLifeTime { get; set; }
        private string _breed { get; set; }
        private int HealthPoint { get; set; }
        private Gender _gender { get; set; }

        public Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }


        public int AvgLifeTime
        {
            get { return _avgLifeTime; }
            set { _avgLifeTime = value; }
        }
        public enum Gender
        {
            get;
        }

        public string Breed
        {
            get => _breed;
        }


        public int HP
        {
            get; set;
        }
        protected Animal(int avglifetime, string breed, int healtpoint, Gender gender)
        {
            Breed = breed;
            AvgLifeTime = AvgLifeTime;
            healtpoint = HealthPoint;
            Gender=gender;
        }
    }
}
