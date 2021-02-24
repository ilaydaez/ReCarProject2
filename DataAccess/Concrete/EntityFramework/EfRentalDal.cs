using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal: IEntityRespositoryBase<Rental, ReCarContext>, IRentalDal
    {
        public List<RentalDetailsDto> GetRentalDetails()
        {
            using (ReCarContext context = new ReCarContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarID equals c.CarID
                             join m in context.Customers
                             on r.CustomerID equals m.CustomerID
                             join u in context.Users
                             on m.UserID equals u.UserID
                             

                             select new RentalDetailsDto
                             {
                                 RentID= r.ID,
                                 RentDate= r.RentDate,
                                 ReturnDate=(DateTime) r.ReturnDate,
                                 CarID = c.CarID,
                                 CarName = c.CarName,
                                 CustomerID = m.CustomerID,
                                 UserFirstName = u.UserFirstName

                             };

                return result.ToList();
            }
        }

        
    }
}
