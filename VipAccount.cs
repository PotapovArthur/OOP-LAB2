namespace Lab2
{
    class VipAccount : GameAccount
    {
        public VipAccount(string name, int startingrating) : base(name, startingrating)
        {
            AccountType = "Платиновий";
        }
        public override void LoseGame(string playername, string opponentname, BaseGame game, string gamemode)
        {
            if (CurrentRating - game.GetRating < 1)
            {
                var negativerating = new Game(playername, opponentname, -CurrentRating + 1, "L", gamemode);
                allGames.Add(negativerating);
            }
            else
            {
                if (game.GetRating < 0)
                {
                    throw new InvalidOperationException("Рейтинг на який грають не може бути негативним");
                }
                var lostgame = new Game(playername, opponentname, -(game.GetRating / 2), "L", gamemode);
                allGames.Add(lostgame);
            }
        }
    }
}