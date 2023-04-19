using System;
namespace MyApp
{


    /*interface IAnimal
    {
       // string Name { get; set; }
        string MakeNoise();
        string Walk();
    }*/


    public class Tiger : IAnimal
    {

		public Tiger(string name)
		{
            
		}

        public string Name { get; set; }

        public string MakeNoise()
        {
            return "Tiger is making a noise";
        }

        public string Walk()
        {
            return "Tiger is walking";
        }

	}
}
