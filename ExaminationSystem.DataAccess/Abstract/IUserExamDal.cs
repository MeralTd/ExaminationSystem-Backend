using ExaminationSystem.Core.DataAccess;
using ExaminationSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.DataAccess.Abstract
{
    public interface IUserExamDal : IEntityRepository<UserExam>
    {
    }
}
