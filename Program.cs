namespace Lab2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nВведiть ваш нiкнейм :");
            string? nickname1 = Console.ReadLine();
            Console.WriteLine("\nВведiть нiкнейм опонента :");
            string? nickname2 = Console.ReadLine();
            Console.WriteLine("\nВведiть початковий рейтинг :");
            int initialrating = Convert.ToInt32(Console.ReadLine());
            //var acc1 = new GameAccount(nickname1!, initialrating);
            var acc1 = new UpgradedAccount(nickname1!, initialrating);
            //var acc1 = new VipAccount(nickname1!, initialrating);
            //var acc2 = new GameAccount(nickname2!, initialrating);
            //var acc2 = new UpgradedAccount(nickname2!, initialrating);
            var acc2 = new VipAccount(nickname2!, initialrating);
            Console.WriteLine("\nСкiльки iгор бажаєте провести :");
            int gamescount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nНа скiльки рейтингу буде кожна з iгор :");
            int bid = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < gamescount; i++)
            {
                Console.WriteLine($"\nТип гри {i + 1} :\n1 - Звичайна, 2 - Для одного гравця, 3 - Тренувальна");
                int gametype = Convert.ToInt32(Console.ReadLine());
                switch (gametype)
                {
                    case 1: var regulargame = CreateGame.GetRegular(acc1, acc2, bid); regulargame.Play(); break;
                    case 2: var sologame = CreateGame.GetSolo(acc1, bid); sologame.Play(); break;
                    case 3: var traininggame = CreateGame.GetTraining(acc1, acc2); traininggame.Play(); break;
                }
            }
            Console.WriteLine($"\nСТАТИСТИКА ГРАВЦЯ {nickname1!} :\n");
            Console.WriteLine(acc1.GetStats());
            Console.WriteLine($"\nСТАТИСТИКА ГРАВЦЯ {nickname2!} :\n");
            Console.WriteLine(acc2.GetStats());
        }
    }
}