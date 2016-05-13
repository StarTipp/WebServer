namespace StartippWebServer.Models
{
    public class GameBet : Entity
    {
        public virtual BettingGroup BettingGroup { get; set; }
        public virtual Game Game { get; set; }
        public virtual byte PredictedWinsGamer1 { get; set; }
        public virtual byte PredictedWinsGamer2 { get; set; }
        public virtual Better Better { get; set; }
        public virtual Tournament Tournament { get; set; }
    }
}