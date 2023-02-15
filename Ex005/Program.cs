Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "катя")
{
    Console.WriteLine("Ну наконец-то ты здесь!");
}
else
 {
    Console.Write("Привет, ");
    Console.WriteLine(username);
}