

Random rnd = new Random();

int myRandom = rnd.Next(1, 11);

Console.WriteLine(myRandom);

for (int i = 0; i < 100; i++)
{
    myRandom = rnd.Next(1, 11);
    Console.WriteLine($"{i + 1}. {myRandom}");
}




//for(int i =; i < 3; i++) // i++ ==> i + 1
//{
//    Console.WriteLine(${i + 1} " I will not skip Zoom classes.");
//}