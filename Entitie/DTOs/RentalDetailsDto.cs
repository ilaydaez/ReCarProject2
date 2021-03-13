using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailsDto: IDto
    {
        //public int RentID { get; set; }
        //public int CarID { get; set; }
        public string CarName { get; set; }
        //public int CustomerID { get; set; }
        //public string CustomerName { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        //public int ImageID { get; set; }
    }
}
