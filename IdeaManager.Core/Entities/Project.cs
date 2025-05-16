namespace IdeaManager.Core.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public int IdeaId { get; set; }            // FK obligatoire
        public Idea Idea { get; set; } = null!;    // Navigation vers l'idée associée
    }
}
