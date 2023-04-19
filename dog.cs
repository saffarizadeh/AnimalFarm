namespace MyApp
{
    public class Dog : IAnimal
    {
        public string Name { get; set; }

        public string Walk()
        {
           return "walk";
        }
        string IAnimal.MakeNoise()
        {
            return "bark, bark";
        }
    }
}
