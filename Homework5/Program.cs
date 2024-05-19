using System;

static (string name, string lastName, int age, string[] pets, string[] favColors) EnterUser()
{
    (string name, string lastName, int age,  string[] pets, string[] favColors) User;

    Console.WriteLine("Введите ваше имя");
    User.name = Console.ReadLine();

    Console.WriteLine("Введите вашу фамилию");
    User.lastName = Console.ReadLine();

    string strAge;
    int intAge;
    do
    {
        Console.WriteLine("Введите ваш возраст");
        strAge = Console.ReadLine();
    }
    while (CheckNumber(strAge, out intAge));
    User.age = intAge;

    Console.WriteLine("Есть ли у вас питомец?");

    string strPetNumber;
    int intPetNumber;
    do
    {
        Console.WriteLine("Сколько у вас питомцев?");
        strPetNumber = Console.ReadLine();
    }
    while (CheckNumber(strAge, out intPetNumber));

    string strFavColorNumber;
    int intFavColorNumber;
    do
    {
        Console.WriteLine("Сколько у вас любимых цветов?");
        strFavColorNumber = Console.ReadLine();
    }
    while (CheckNumber(strAge, out intFavColorNumber));

    return User;
}
static bool CheckNumber(string strNumber, out int corrNumber)
{
    if (int.TryParse(strNumber, out int number))
    {
        if (number > 0) 
        {
            corrNumber = number;
            return false;
        }
    }
    corrNumber = 0;
    return true;
}