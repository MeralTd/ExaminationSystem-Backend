using ExaminationSystem.Core.Utilities.Results;
using ExaminationSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Business.Abstract
{
    public interface IChoiceService
    {
        IResult Add(Choice choice);
        IResult Update(Choice choice);
        IResult Delete(Choice choice);
        IDataResult<Choice> GetById(int choiceId);
        IDataResult<List<Choice>> GetAll();
        IDataResult<List<Choice>> GetByQuestionId(int questionId);

    }
}
