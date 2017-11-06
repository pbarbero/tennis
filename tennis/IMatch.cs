namespace tennis
{
    public interface IMatch
    {
        Player player1 { get; set; }
        Player player2 { get; set; }

        void PlayMatch();
        Player RandomPlayer();
    }
}