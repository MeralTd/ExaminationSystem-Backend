using ExaminationSystem.Core.DataAccess.EntityFramework;
using ExaminationSystem.DataAccess.Abstract;
using ExaminationSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.DataAccess.Concrete
{
    public class EfChoiceDal: EfEntityRepositoryBase<Choice, ExamContext>, IChoiceDal
    {
    }
}
