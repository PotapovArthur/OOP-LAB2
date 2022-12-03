namespace Lab2
{
    public class RegularGame : BaseGame
    {
        public RegularGame(GameAccount account1, GameAccount account2, int Rating) : base(account1, account2, Rating)
        {

        }
        public override void Play()
        {
            Random random = new Random();
            int n = random.Next(0, 2);
            if (n == 0)
            {
                Account1.WinGame(Account1.UserName, Account2.UserName, this, "Звичайна");
                Account2.LoseGame(Account2.UserName, Account1.UserName, this, "Звичайна");
            }
            else
            {
                Account2.WinGame(Account2.UserName, Account1.UserName, this, "Звичайна");
                Account1.LoseGame(Account1.UserName, Account2.UserName, this, "Звичайна");
            }
        }
    }
}