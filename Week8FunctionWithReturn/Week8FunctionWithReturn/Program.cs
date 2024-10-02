
using System.Data;

string[] tvShows = { "Firefly", "Office", "The last of us", "friends", "Twin peaks", "House", "Stranger things" };
string[] food = { "sushi", "pizza", "chinese takeaway", "burger ande chips", "chicken wings", "chips", "popcorn" };
string[] drinks = { "mineral water", "coca-cola", "apple juice", "milk", "beer" };

//PickRandomFromArray(tvShows);
//PickRandomFromArray(food);
//PickRandomFromArray(drinks);

string randomMovie = PickRandomFromArray(tvShows);
string randomFood = PickRandomFromArray(food);
string randomDrink = PickRandomFromArray(drinks);

Console.WriteLine($"I recommend you to watch {randomMovie} tonight.");
Console.WriteLine($"Order some {randomFood} and {randomDrink}.");


static string PickRandomFromArray(string[] someArray)
{
    PickRandomFromArray rnd = new PickRandomFromArray();

    int randomIndex = rnd.Next(0, someArray.Length);
    string randomElement = someArray[randomIndex];
    Console.WriteLine(randomElement);
    return randomElement;
}


//Random rnd = new Random();

//int randomIndex = rnd.Next(0, tvShows.Length);
//string randommovie = tvShows[randomIndex];
//Console.Writeline(randomMovie);

//randomIndex = rnd.Next(0, food.Length);
//string randomFood = food[randomIndex];
//Console.Writeline(randomFood);

//randomIndex = rnd.Next(0, drinks.Length);
//string randomDrinks = drinks[randomIndex];
//Console.Writeline(randomDrink);
