﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<Rental> GetByRentID(int carID);
        IDataResult<List<Rental>> GetByRental();
        IDataResult<List<Rental>> GetRentByCarID(int rentID);
        IDataResult<List<Rental>> GetRentByCustomerID(int customerID);
        IDataResult<List<Rental>> GetRentDate(DateTime date);
        IDataResult<List<Rental>> GetReturnDate(DateTime returnDate);
        IDataResult<List<RentalDetailsDto>> GetRentalDetails();
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult UpDate(Rental rental);

        IResult CheckCarStatus(Rental rental);
    }
}
