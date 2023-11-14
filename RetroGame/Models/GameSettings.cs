namespace RetroGame.Models
{
    public class GameSettings
    {
        public List<string> PlayerNames { get; set; } = new List<string>();
        public bool IsRandomMap { get; set; }
        public int DiceMaxNumber { get; set; }
    }
}
