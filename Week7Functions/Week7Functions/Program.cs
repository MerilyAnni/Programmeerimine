string hello = "Hello, world!";

string panic = "Don't panic!";

//for(int i = 0; i<5; i++)
//{
// Console.Writeline(hello);
//}
//for (int i = 0 < 5; i++)
//{
//Console.Writeline(panic);
//}


PrintStringFiveTimes(hello);
PrintStringFiveTimes(panic);
PrintStringFiveTimes("Merily");

static void PrintStringFiveTimes(string someString)
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(someString);

    }

}

    
