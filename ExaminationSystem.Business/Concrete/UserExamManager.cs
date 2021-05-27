using ExaminationSystem.Business.Abstract;
using ExaminationSystem.Core.Utilities.Results;
using ExaminationSystem.DataAccess.Abstract;
using ExaminationSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Business.Concrete
{
    public class UserExamManager:IUserExamService
    {
        IUserExamDal _userExamDal;

        public UserExamManager(IUserExamDal userExamDal)
        {
            _userExamDal = userExamDal;
        }
        public IResult Add(UserExam userExam)
        {
            _userExamDal.Add(userExam);
            return new SuccessResult();
        }

        public IResult Delete(UserExam userExam)
        {
            _userExamDal.Delete(userExam);
            return new SuccessResult();
        }

        public IDataResult<List<UserExam>> GetAll()
        {
            return new SuccessDataResult<List<UserExam>>(_userExamDal.GetAll());
        }

        public IDataResult<UserExam> GetById(int userExamId)
        {
            return new SuccessDataResult<UserExam>(_userExamDal.Get(u => u.Id == userExamId));

        }

        public IResult Update(UserExam userExam)
        {
            _userExamDal.Update(userExam);
            return new SuccessResult();
        }
    }
}
