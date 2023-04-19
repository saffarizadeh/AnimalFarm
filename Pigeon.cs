using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{

   

    public class Pigeon  : IAnimal
    {
       
        public string Name { get; set; }  

        public string MakeNoise()
        {
            return "Squak";
        }

        public string Walk()
        {
            return "Walking";
        }

        public string Fly()
        {
            return "Flapping wings";
        }

        public string Eat()
        {
            return "Uses beak to eat";
        }
    }
}
