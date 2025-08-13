using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class DummyFunction
    {
        public string ReturnPikachuIfZero (int num)
        {

            if (num == 0)
            {
                return "Pikachu";
            }
            else
            {
                return "Not Pikachu";
            }        
        }
    }
}
