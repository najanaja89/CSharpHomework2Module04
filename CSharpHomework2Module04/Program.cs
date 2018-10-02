using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework2Module04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rocket r1;
            //Rocket r2;
            //Rocket r3;
            //Rocket r4;
            //Rocket r5;

            Rocket[] rocketArray = new Rocket[5];

            for (int i = 0; i < 5; i++)
            {
                rocketArray[i] = new Rocket();
                Console.WriteLine(rocketArray[i].GetName());
            }

            Console.ReadLine();
        }
    }
}
