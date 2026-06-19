public class Player
{
    public string Username {get; private set;}
    public int Score {get; private set;}
    public int Wins {get; private set;}
    public double PlayTime {get; private set;}
    public Player (string username, int score, int wins, double playTime)
    {
        Username = username;
        Score = score;
        Wins = wins;
        PlayTime = playTime;
    }
}