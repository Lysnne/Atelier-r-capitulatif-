namespace IdeaManager.Core.Entities
{
    public class Vote
    {
        public int Id { get; set; }

        // Relation avec l'utilisateur qui a voté
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        // Relation avec l'idée votée
        public int IdeaId { get; set; }
        public Idea Idea { get; set; } = null!;

        // Date du vote
        public DateTime VotedAt { get; set; } = DateTime.UtcNow;
    }
}
