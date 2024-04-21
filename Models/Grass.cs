using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._04._2024.Models
{
    internal class Grass : Food
    {
        private string _name {  get; set; }

        public string Name
        {
            get { return _name; } set { _name = value; }
        }

        public Grass(int calorie, string name) : base(calorie)
        {
            Name = name;
        }
    }
}
