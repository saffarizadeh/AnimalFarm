namespace MyApp;

interface IAnimal
{
    string Name { get; set; }
    string MakeNoise();
    string Walk();
}

public class Owl : IAnimal
{
    public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public string MakeNoise()
    {
        string n = "Whoooooo";
        return n;
    }

    public string Walk()
    {
        string w = "pat pat pat...";
        return w; 
    }
}
