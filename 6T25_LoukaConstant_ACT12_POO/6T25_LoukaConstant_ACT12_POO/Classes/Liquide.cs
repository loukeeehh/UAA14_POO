using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T25_LoukaConstant_ACT12_POO.Classes
{
    internal class Liquide
    {
        private string _name;
        private string _type;

        public Liquide(string name, string type)
        {
            _name = name;
            _type = type;
        }

        public string Name
        {
            get { return _name; }
            set { _type = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }



    }
}
