
string[] fruitBasket = { "apples", "bananas", "oranges" };

Console.WriteLine(value: $"There are {fruitbasket.Length} fruit in your basket. ");

Console.WriteLine(fruitBasket[0]);
Console.WriteLine(fruitBasket[1]);
Console.WriteLine(fruitBasket[2]);
    
fruitBasket[0] = "pine-apple";
fruitBasket[2] = "peaches";
fruitBasket[3] = "Melon";

Console.WriteLine(fruitBasket[0]);
Console.WriteLine(fruitBasket[1]);
Console.WriteLine(fruitBasket[2]);

for (int i = 0; i < fruitBasket.Length; i++)
{
    Console.WriteLine(fruitBasket[i]);
}

