using ExaminationSystem.Core.Entities;

namespace ExaminationSystem.Entities.Concrete
{
    public class Choice : IEntity
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public string Text { get; set; }
        public bool Correct { get; set; }
    }
}
