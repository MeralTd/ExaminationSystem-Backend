using ExaminationSystem.Core.Entities;
using System.Collections.Generic;

namespace ExaminationSystem.Entities.Concrete
{
    public class Exam : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<UserExam> UserExams { get; set; }
        public ICollection<Question> Questions { get; set; }

    }
}
