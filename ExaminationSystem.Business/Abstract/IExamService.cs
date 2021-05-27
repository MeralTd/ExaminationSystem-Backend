using ExaminationSystem.Core.Utilities.Results;
using ExaminationSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Business.Abstract
{
    public interface IExamService
    {
        IResult Add(Exam exam);
        IResult Update(Exam exam);
        IResult Delete(Exam exam);
        IDataResult<Exam> GetById(int examId);
        IDataResult<List<Exam>> GetAll();
    }
}
