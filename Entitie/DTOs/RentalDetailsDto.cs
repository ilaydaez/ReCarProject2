using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailsDto: IDto
    {
        public int RentID { get; set; }
        public int UserID { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string CustomerName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string CardNameSurname { get; set; }
        public string CardNumber { get; set; }
        public string CardExpiryDate { get; set; }
        public string CardCvv { get; set; }
        public int AmountPaye { get; set; }
        public string CarName { get; set; }


    }
}
