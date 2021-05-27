using ExaminationSystem.Business.Abstract;
using ExaminationSystem.Business.Constants;
using ExaminationSystem.Business.ValidationRules.FluentValidation;
using ExaminationSystem.Core.Aspects.Autofac.Validation;
using ExaminationSystem.Core.Utilities.Business;
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
    public class ChoiceManager: IChoiceService
    {
        IChoiceDal _choiceDal;

        public ChoiceManager(IChoiceDal choiceDal)
        {
            _choiceDal = choiceDal;
        }

        [ValidationAspect(typeof(ChoiceValidator))]
        public IResult Add(Choice choice)
        {
            IResult result = BusinessRules.Run(CheckTrueCorrect(choice.Correct, choice.QuestionId));
            if (result != null)
            {
                return result;
            }
            _choiceDal.Add(choice);
            return new SuccessResult();
        }

        public IResult Delete(Choice choice)
        {
            _choiceDal.Delete(choice);
            return new SuccessResult();
        }

        public IDataResult<List<Choice>> GetAll()
        {
            return new SuccessDataResult<List<Choice>>(_choiceDal.GetAll());
        }

        public IDataResult<Choice> GetById(int choiceId)
        {
            return new SuccessDataResult<Choice>(_choiceDal.Get(u => u.Id == choiceId));
        }

        public IDataResult<List<Choice>> GetByQuestionId(int questionId)
        {
            return new SuccessDataResult<List<Choice>>(_choiceDal.GetAll(u => u.QuestionId == questionId));
        }

        public IResult Update(Choice choice)
        {
            _choiceDal.Update(choice);
            return new SuccessResult();
        }

        private IResult CheckTrueCorrect(bool correct,int questionId)
        {
            var trueCorrectCount = _choiceDal.GetAll(q => q.QuestionId == questionId && q.Correct == true).Count;

            if (trueCorrectCount>=1 && correct == true)
            {
                 return new ErrorResult(Messages.ChoiceCount);
            }
            else if (trueCorrectCount >= 1 && correct == false)
            {
                return new SuccessResult();

            }

            return new SuccessResult();
        }
    }
}
