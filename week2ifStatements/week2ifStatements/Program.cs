Console.WriteLine("enter your first name:");
string userName = Console.ReadLine();

Console.WriteLine("Enter your gender (f/m/n):");
char userGender = Char.Parse(Console.ReadLine());

string greeting;

if (userGender == 'f')
{
    greeting = "Ms.";
}
else if (userGender == 'm')
{
    greeting = "Mr.";
}


else
{
    greeting = "";
}


Console.WriteLine($"Hello, {greeting}  {userName}!");

Console.WriteLine("Enter your year of birth:");

int usersYB = Int32.Parse(Console.ReadLine());

int currentYear = DateTime.Now.Year;

int userAge = currentYear - usersYB;

//Console.WriteLine($"Current year: {currentYear}");

//int userAge = Int32.Parse(Console.ReadLine());



if (userAge >= 13)
{
    Console.WriteLine("You are {usersYB} old enough to have an account");
}
else
{
    Console.WriteLine("You are {usersYB} too young to have an account");
}
        