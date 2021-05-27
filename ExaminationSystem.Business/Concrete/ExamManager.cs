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
    public class ExamManager : IExamService
    {
        IExamDal _examDal;

        public ExamManager(IExamDal examDal)
        {
            _examDal = examDal;
        }
        public IResult Add(Exam exam)
        {
            _examDal.Add(exam);
            return new SuccessResult();
        }

        public IResult Delete(Exam exam)
        {
            _examDal.Delete(exam);
            return new SuccessResult();
        }

        public IDataResult<List<Exam>> GetAll()
        {
            return new SuccessDataResult<List<Exam>>(_examDal.GetAll());
        }

        public IDataResult<Exam> GetById(int examId)
        {
            return new SuccessDataResult<Exam>(_examDal.Get(u => u.Id == examId));

        }

        public IResult Update(Exam exam)
        {
            _examDal.Update(exam);
            return new SuccessResult();
        }
    }
}
