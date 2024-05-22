using System;

//EnterUser();
ShowUser(EnterUser());

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

    Console.WriteLine("Есть ли у вас питомец? Если есть, введите 'Да', иначе введите другое слово");
    string havePet = Console.ReadLine();
    if (havePet == "Да")
    {
        string strPetNumber;
        int intPetNumber;
        do
        {
            Console.WriteLine("Сколько у вас питомцев?");
            strPetNumber = Console.ReadLine();
        }
        while (CheckNumber(strPetNumber, out intPetNumber));
        User.pets = PetsNames(intPetNumber);
    }
    else
    {
        User.pets = null;
    }
    
    string strFavColorNumber;
    int intFavColorNumber;
    do
    {
        Console.WriteLine("Сколько у вас любимых цветов?");
        strFavColorNumber = Console.ReadLine();
    }
    while (CheckNumber(strFavColorNumber, out intFavColorNumber));
    User.favColors = FavColors(intFavColorNumber);

    return User;
}

static void ShowUser((string name, string lastName, int age, string[] pets, string[] favColors) User)
{
    Console.WriteLine();
    Console.WriteLine($"Ваше имя: {User.name}");
    Console.WriteLine($"Ваша фамилия: { User.lastName}");
    Console.WriteLine($"Вам {User.age} лет");
    if (User.pets != null)
    {
        Console.WriteLine($"У вас {User.pets.Length} питомцев:");
        foreach ( var pet in User.pets)
        {
            Console.WriteLine(pet);
        }
    }
    else
    {
        Console.WriteLine("У вас нет питомцев");
    }
    Console.WriteLine($"У вас {User.favColors.Length} любимых цветов:");
    foreach (var favColor in User.favColors)
    {
        Console.WriteLine(favColor);
    }
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

static string[] PetsNames(int number)
{
    string[] names = new string[number];
    for (int i = 0; i < names.Length; i++)
    {
        Console.WriteLine($"Имя питомца {i + 1}");
        names[i] = Console.ReadLine();
    }
    return names;
}

static string[] FavColors(int number)
{
    string[] colors = new string[number];
    for (int i = 0; i < colors.Length; i++)
    {
        Console.WriteLine($"Цвет {i + 1}");
        colors[i] = Console.ReadLine();
    }
    return colors;
}