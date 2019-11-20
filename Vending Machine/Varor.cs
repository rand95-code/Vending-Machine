using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine
{
    class Varor
    {

        //press one for . 

        private string _Name;
        private string _Price;
        private string _Caloris; 

        public string Name

        {
            get { return _Name; } 
            set { _Name = value; }
        }

        public string Price

        {
            get { return _Price; }
            set { _Price = value; }
        }

        public string Caloris
        {
            get { return _Caloris; }
            set { _Caloris = value;  }
        }
        private string _GetNameData()
        {
            return _Name + ";" + _Price + ";" + _Caloris;
        }
        public string GetNameData()
        {
            return _GetNameData().Replace(";", "\n"); 
        }

        public void PrintNameData()
        {
            Console.WriteLine(GetNameData());
        }
    }
}
