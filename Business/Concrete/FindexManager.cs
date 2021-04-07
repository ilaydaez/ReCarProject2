using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class FindexManager : IFindexService
    {
        IFindexDal _findexDal;
        public FindexManager(IFindexDal findexDal)
        {
            _findexDal = findexDal;
        }

        public IResult Add(Findex findex)
        {
            _findexDal.Add(findex);
            return new SuccessResult();
        }

        public IResult Delete(Findex findex)
        {
            _findexDal.Delete(findex);
            return new SuccessResult();
        }

        public IDataResult<Findex> GetById(int id)
        {
            return new SuccessDataResult<Findex>(_findexDal.Get(a => a.Id == id));
        }

        public IDataResult<List<Findex>> GetByUserId(int id)
        {
            return new SuccessDataResult<List<Findex>>(_findexDal.GetAll(p => p.Id == id));
        }

        public IResult Update(Findex findex)
        {
            _findexDal.Update(findex);
            return new SuccessResult();
        }
    }
}
