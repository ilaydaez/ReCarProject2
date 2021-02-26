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
    public class CustomerManager : ICustomerService

    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            ValidationTool.Validate(new CustomerValidator(), customer);
            _customerDal.Add(customer);

            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);

            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<Customer> GetByCustomerID(int customerID)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(u => u.CustomerID == customerID));
        }

        public IDataResult<List<Customer>> GetByCustomers()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<List<Customer>> GetCustomerByCompany(string customerCompany)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(u => u.CompanyName == customerCompany));
        }

        public IDataResult<List<Customer>> GetCustomerByUserID(int userID)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(u => u.UserID == userID));
        }

        public IResult UpDate(Customer customer)
        {
            _customerDal.Update(customer);

            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
