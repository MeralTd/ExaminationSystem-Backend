using ExaminationSystem.Core.Entities;
using System.Collections.Generic;

namespace ExaminationSystem.Entities.Concrete
{
    public class Question : IEntity
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
        public string Text { get; set; }
        public int Score { get; set; }
        public ICollection<Choice> Choices { get; set; }


    }
}
