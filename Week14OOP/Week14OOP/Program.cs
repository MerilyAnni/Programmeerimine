using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Dog goodBoy = new Dog("Good Dog");

        Console.WriteLine(value: $"Name: {goodboy.Name}; Level of happiness: {goodBoy.LevelOfHappiness}");

        goodBoy.Bark();

        Console.WriteLine("Name: {goodboy.Name}; Level of happiness: {goodBoy.LevelOfHappiness}");

        while (goodBoy.LevelOfHappiness < 5)
        {
            goodBoy.Bark();

        }
        goodBoy.Wag();
    }
}

class Dog
{
    public string Name;
    public int LevelOfHappiness;
    private object console;

    public Dog(string name)
    {
        Name = name;
        LevelOfHappiness = 0;
        Console.WriteLine($"{Name} is your friend now.");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-Woof!");
    }

    public void Wag()
    {
        Console.WriteLine("{Name:} starts with wagging its tail. ");
        Console.WriteLine("woosh-Woosh");
    }

}