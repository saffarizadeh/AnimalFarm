namespace MyApp
{
    public class Chicken : IAnimal
    {
        public string Name { get; set; }

        public string Walk()
        {
           return "waddle waddle";
        }
        string IAnimal.MakeNoise()
        {
            return "cluck, cluck";
        }
    }
}
