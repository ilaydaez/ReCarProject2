using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal: EfEntityRepositoryBase<Customer, ReCarContext>, ICustomerDal
    {
        public List<CustomerDetailsDto> GetCustomerDetails(Expression<Func<Customer, bool>> filter = null)
        {
            using (ReCarContext context = new ReCarContext())
            {

                var result = from customer in filter is null ? context.Customers : context.Customers.Where(filter)
                             join user in context.Users on customer.Id equals user.Id
                             select new CustomerDetailsDto
                             {
                                 CompanyName = customer.CompanyName,
                                 UserFirstName=user.UserFirstName,
                                 UserLastName=user.UserLastName,
                                 UserFindexScore=user.UserFindexScore
                                 
                             };


                return result.ToList();
            }

        }
    }
}
