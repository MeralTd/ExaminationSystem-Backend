using ExaminationSystem.Core.Utilities.Results;
using ExaminationSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Business.Abstract
{
    public interface IQuestionService
    {
        IResult Add(Question question);
        IResult Update(Question question);
        IResult Delete(Question question);
        IDataResult<Question> GetById(int questionId);
        IDataResult<List<Question>> GetAll();
        IDataResult<List<Question>> GetByExamId(int examId);
    }
}
