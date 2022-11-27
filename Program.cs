
namespace Task12._1._5
{
    class Program
    {
        static void Main()
        {
            
            User[] users = new User[] { new User { Login = "Никита95", Name = "Никита", IsPremium = true},
                new User {Login = "Максим2003", Name = "Максим", IsPremium = false } };

            foreach (var user in users)
            {
                switch (user.IsPremium)
                {
                    case true:
                        Console.WriteLine($"Привет, {user.Name}. У тебя премиальный аккаунт.");
                        Console.WriteLine("Наслаждайся контентом.");
                        Console.WriteLine();
                        break;
                    case false:
                        Console.WriteLine($"Привет, {user.Name}. У тебя бесплатный аккаунт. Смотри рекламу.");
                        ShowAds();
                        break;
                }
            }

        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}