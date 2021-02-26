using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            ValidationTool.Validate(new UserValidator(), user);

            _userDal.Add(user);

            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {

            _userDal.Delete(user);

            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<User> GetByUserID(int userID)
        {
            return new SuccessDataResult<User>(_userDal.Get( u => u.UserID == userID));
        }

        public IDataResult<List<User>> GetByUsers()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<List<User>> GetUserByEmail(string userEmail)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(u => u.Email == userEmail));
        }

        public IResult UpDate(User user)
        {
            if (user.UserFirstName.Length < 2)
            {
                return new ErrorResult(Messages.UserFirstNameInvalid);
            }

            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
