using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    interface IAnimal
    {
        string Name { get; set; }
        string MakeNoise();
        string Walk();
    }

    public class Moose : IAnimal
    {
        public string Name { get; set; }

        public string MakeNoise()
        {
            return "Bellow";

        }

        public string Walk()
        {
            return "gallop";
        }
    }
}
