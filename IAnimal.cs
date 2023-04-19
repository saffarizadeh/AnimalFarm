namespace MyApp;

interface IAnimal
{
  string Name {get; set;}
  string MakeNoise();
  string Walk();
}
    public class Tortuga : IAnimal
    {
        public string Name { get; set; }

        public string MakeNoise()
        {
            return "Buble, Buble";

        }

        public string Walk()
        {
            return "Swim!";
        }


    }
