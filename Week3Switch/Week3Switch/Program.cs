int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);
Console.WriteLine(weekDay);

switch (weekDay)
{

    case 0:
        Console.WriteLine("Sunday");
        break; 
        case 1:
        Console.WriteLine("Monday");
        break;
        case 2:
        Console.WriteLine("Tuesday)";
        break; 
        case 3: 
        Console.WriteLine("Wednesday");
        break;
        case 4:
        Console.WriteLine("Thrusday");
        break;  
        case 5:
        Console.WriteLine("Friday");
        break;
        case 6:
        Console.WriteLine("Saturday");
        break;
       default:
        Console.WriteLine("Invalid value");
        break;


}


//if (weekDay == 0)
//{
//    Console.WriteLine("Sunday");
//}
//else if (weekDay == 1)
//{
//    Console.WriteLine("Monday");
//}
//else if (weekDay == 2)
//{
//    Console.WriteLine("Tuesday");

//}else if (weekDay == 3)
//{
//    Console.WriteLine("Wednesday");
//}
//else if (weekDay == 4)
//{
//    Console.WriteLine("Thrusday");
//}
//else if (weekDay == 5)
//{
//    Console.WriteLine("Friday");
//}
//else
//{
//    Console.WriteLine("Saturday");
//}
