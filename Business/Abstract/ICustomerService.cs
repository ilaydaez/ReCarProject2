using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<Customer> GetByCustomerID(int customerID);
        IDataResult<List<Customer>> GetByCustomers();
        IDataResult<List<Customer>> GetCustomerByUserID(int userID);
        IDataResult<List<Customer>> GetCustomerByCompany(string customerCompany);
        IDataResult<List<CustomerDetailsDto>> GetCustomerDetails();
        IResult Add(Customer customer);
        IResult Delete(Customer customer);
        IResult UpDate(Customer customer);
        IDataResult<List<Customer>> GetByUserId(int id);
    }
}
