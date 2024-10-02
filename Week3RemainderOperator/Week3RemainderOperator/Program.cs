//odd or even

int a = 110;

int result = a % 2;

Console.WriteLine(result);

//if (result == 0)
//{
//    Console.WriteLine($"{a} is an even number");
//} else
//{
//    Console.WriteLine($"{a} is an odd number");
//}

switch (result)
{
    case 0:
        Console.WriteLine($"{a} is an even number");
        break;
        case 1:
        Console.WriteLine($"{a} is an odd number");
        break;
    default
        Console.WriteLine("Invalid value");
}
