using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Test
{
    public class DummyFunctionTest
    {
        public static void DummyFunctionTest_ReturnPikachuIfZero_ReturnString() 
        {
            try
            {
                int num = 10;
                DummyFunction dummy = new DummyFunction();

                string result = dummy.ReturnPikachuIfZero(num);

                if (result == "Pikachu")
                {
                    Console.WriteLine("Passed : DummyFunction");
                }

                else
                {
                    Console.WriteLine("Failed : Dummy Function");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed : Not Pikachu");
            }
        }
    }
}
