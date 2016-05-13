namespace StartippWebServer.Models
{
    public class GameBet : Entity
    {
        public virtual BettingGroup BettingGroup { get; set; }
        public virtual Game Game { get; set; }
        public virtual byte PredictedWinsGamer1 { get; set; }
        public virtual byte PredictedWinsGamer2 { get; set; }
    }
}