static (string name, string lastName, int age, bool haveAPet, int petNumber, string[] pets, int favColorNumber, string[] favColors) EnterUser()
{
    (string name, string lastName, int age, bool haveAPet, int petNumber, string[] pets, int favColorNumber, string[] favColors) User;

    Console.WriteLine("Введите ваше имя");
    User.name = Console.ReadLine();

    Console.WriteLine("Введите вашу фамилию");
    User.lastName = Console.ReadLine();

    Console.WriteLine("Введите ваш возраст");
    string strAge = Console.ReadLine();

    Console.WriteLine("Есть ли у вас питомец?");
    User.haveAPet = true;

    Console.WriteLine("Сколько у вас питомцев?");
    string strPetNumber = Console.ReadLine();

    Console.WriteLine("Сколько у вас любимых цветов?");
    string strFavColorNumber = Console.ReadLine();

    return User;
}