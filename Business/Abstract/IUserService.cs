using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<User> GetByUserID(int userID);
        IDataResult<List<User>> GetByUsers(); 
        IDataResult<List<User>> GetUserByEmail(string userEmail);
        IResult Add(User user);
        IResult Delete(User user);
        IResult UpDate(User user);
    }
}
