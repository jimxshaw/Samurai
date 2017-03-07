namespace SamuraiApp.Domain
{
    // Many-to-many relationships with EF Core must utilize a joining class.
    public class SamuraiBattle
    {
        public int SamauraiId { get; set; }
        public Samurai Samurai { get; set; }
        public int BattleId { get; set; }
        public Battle Battle { get; set; }
    }
}
