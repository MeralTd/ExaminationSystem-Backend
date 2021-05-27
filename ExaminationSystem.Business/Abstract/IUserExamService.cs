using ExaminationSystem.Core.Utilities.Results;
using ExaminationSystem.Entities.Concrete;
using System.Collections.Generic;

namespace ExaminationSystem.Business.Abstract
{
    public interface IUserExamService
    {
        IResult Add(UserExam userExam);
        IResult Update(UserExam userExam);
        IResult Delete(UserExam userExam);
        IDataResult<UserExam> GetById(int userExamId);
        IDataResult<List<UserExam>> GetAll();
    }
}
