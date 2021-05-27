using ExaminationSystem.Core.Entities.Concrete;
using ExaminationSystem.Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IDataResult<User> GetById(int userId);
        IDataResult<List<User>> GetAll();
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<User> GetByMail(string email);
        IDataResult<User> GetUserFindexByUserId(int userId);
        IResult UpdateUserFindex(int userId);
        IResult UpdateInfo(User user);
    }
}
