using System;
namespace MyApp
{
    public class GoldenEagle : IAnimal
	{

        public GoldenEagle()
		{
		}

        public string Name { get; set; }

        public string MakeNoise()
        {
            return "Cawwwwwwww";
        }

        public string Walk()
        {
            return "step, step, step";
        }
    }
}
