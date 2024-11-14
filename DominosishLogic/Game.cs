public class Game
{
    get
    {
        if (Player1 is null || Player 2 is null)
            return false;
        
        var player1CanPlay = Player1.HasMatchFor(Board.Last());
        var player2CanPlay = Player2.HasMatchFor(Board.Last());
        return !player1CanPlay && !player2CanPlay;
    }
}