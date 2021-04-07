using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFindexService
    {
        IResult Add(Findex findex);
        IResult Update(Findex findex);
        IResult Delete(Findex findex);
        IDataResult<Findex> GetById(int id);
        IDataResult<List<Findex>> GetByUserId(int id);
    }
}
