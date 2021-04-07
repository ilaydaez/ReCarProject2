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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCarContext>, IRentalDal
    {
        //public List<RentalDetailsDto> GetRentalDetails()
        //{
        //    using (ReCarContext context = new ReCarContext())
        //    {
        //        var result = from r in context.Rentals
        //                     join c in context.Cars
        //                     on r.CarID equals c.CarID
        //                     join m in context.Customers
        //                     on r.CustomerID equals m.CustomerID
        //                     join u in context.Users
        //                     on m.UserID equals u.Id


        //                     select new RentalDetailsDto
        //                     {
        //                         //RentID= r.ID,
        //                         RentDate = r.RentDate,
        //                         ReturnDate = (DateTime)r.ReturnDate,
        //                         //CarID = c.CarID,
        //                         CarName = c.CarName,
        //                         //CustomerID = m.CustomerID,
        //                         UserFirstName = u.UserFirstName,
        //                         UserLastName = u.UserLastName

        //                     };

        //        return result.ToList();
        //    }
        //}

        public bool CheckCarStatus(int carID, DateTime rentDate, DateTime? returnDate)
        {
            using (ReCarContext context = new ReCarContext())
            {
                bool checkReturnDateIsNull = context.Set<Rental>().Any(p => p.CarID == carID && p.ReturnDate == null);
                bool isValidRentDate = context.Set<Rental>()
                    .Any(r => r.CarID == carID && (
                            (rentDate >= r.RentDate && rentDate <= r.ReturnDate) ||
                            (returnDate >= r.RentDate && returnDate <= r.ReturnDate) ||
                            (r.RentDate >= rentDate && r.RentDate <= returnDate)
                            )
                    );

                if ((!checkReturnDateIsNull) && (!isValidRentDate))
                {
                    return true;
                }

                return false;
            }
        }

        public List<RentalDetailsDto> GetRentalDetails()
        {
            using (ReCarContext context = new ReCarContext())
            {
                var result = from ra in context.Rentals
                             join c in context.Cars
                             on ra.CarID equals c.CarID
                             join co in context.Customers
                             on ra.CustomerID equals co.CustomerID
                             join u in context.Users
                             on co.Id equals u.Id
                             join b in context.Brands
                             on c.BrandID equals b.BrandID
                             join p in context.Payments
                             on ra.PaymentID equals p.PaymentID
                             select new RentalDetailsDto
                             {
                                 RentID = ra.ID,
                                 BrandName = b.BrandName,
                                 //ModelName = c.ModelName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 UserFirstName = u.UserFirstName + " " + u.UserLastName,
                                 CustomerName = co.CompanyName,
                                 RentDate = ra.RentDate,
                                 ReturnDate = ra.ReturnDate,
                                 CardNameSurname = p.CardNameSurname,
                                 CardNumber = p.CardNumber,
                                 CardExpiryDate = p.CardExpiryDate,
                                 CardCvv = p.CardCvv,
                                 AmountPaye = p.AmountPaye

                             };
                return result.ToList();
            }


        }
    }
}
