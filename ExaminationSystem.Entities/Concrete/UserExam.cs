using ExaminationSystem.Core.Entities;
using ExaminationSystem.Core.Entities.Concrete;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Entities.Concrete
{
    public class UserExam : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
        public int Score { get; set; }
        public int AnswerSheet { get; set; }
    }
}
