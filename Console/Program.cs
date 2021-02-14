using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            

            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());








            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------ARAÇLAR LİSTESİ-----------------------------");
            Console.ResetColor();
            Console.WriteLine(" ");
            Console.WriteLine(String.Format("{0,-12} | {1,-12} | {2,-13} | {3,-13} | {4,-13} | {5,-13} | {6,-15} | {7,-20}| {8,-20} ", "CarID", "CarName", "BrandID", "BranName", "ColorID", "ColorName", "ModelYear", "DailyPrice", "Description"));
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");


            var resultListed = carManager.GetCarDetails();
            if (resultListed.Success == true)
            {
                foreach (var car in resultListed.Data)
                {

                    Console.WriteLine(String.Format("{0,-12} | {1,-12} | {2,-13} | {3,-13} | {4,-13} | {5,-13} | {6,-15} | {7,-20}| {8,-20} ", car.CarID,
                                car.CarName, car.BrandID, car.BrandName, car.ColorID, car.ColorName, car.ModelYear, car.DailyPrice, car.Description));
                }
            }
            else
            {
                Console.WriteLine(resultListed.Massage);
            }



            Console.WriteLine(" ");

            var resultAdded = carManager.Add(new Car
            {

                CarName = "Nur",
                BrandID = 3,
                ColorID = 1,
                ModelYear = 2010,
                DailyPrice = 900,
                Description = "Manuel Benzinli"

            });

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(resultAdded.Massage);
            Console.ResetColor();



            Console.WriteLine(" ");


            var resultDeleted = carManager.Delete(new Car { CarID = 10020 });

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(resultDeleted.Massage);
            Console.ResetColor();



            Console.WriteLine(" ");

            var resultUpdated = carManager.UpDate(new Car
            {
                CarID = 4,
                CarName = "Kia",
                BrandID = 3,
                ColorID = 1,
                ModelYear = 2010,
                DailyPrice = 400,
                Description = "Manuel Benzinli"
            });

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("CarID = " + "4" + " => " + resultUpdated.Massage);
            Console.ResetColor();



            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------GÜNCEL ARAÇ LİSTESİ-----------------------------");
            Console.ResetColor();
            Console.WriteLine(" ");
            Console.WriteLine(String.Format("{0,-12} | {1,-12} | {2,-13} | {3,-13} | {4,-13} | {5,-13} | {6,-15} | {7,-20}| {8,-20} ", "CarID", "CarName", "BrandID", "BranName", "ColorID", "ColorName", "ModelYear", "DailyPrice", "Description"));
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            var resultUpdatedList = carManager.GetCarDetails();
            if (resultUpdatedList.Success == true)
            {
                foreach (var car in resultUpdatedList.Data)
                {

                    Console.WriteLine(String.Format("{0,-12} | {1,-12} | {2,-13} | {3,-13} | {4,-13} | {5,-13} | {6,-15} | {7,-20}| {8,-20} ", car.CarID,
                                car.CarName, car.BrandID, car.BrandName, car.ColorID, car.ColorName, car.ModelYear, car.DailyPrice, car.Description));
                }
            }


            Console.WriteLine(" ");

            var userAdded = userManager.Add(new User
            {
                UserFirstName = "Hasan",
                UserLastName = "Atik",
                Email = "Hatik@gmail.com",
                Password = 11111117


            });

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("UserName = " + "Hasan Atik " + " => " + userAdded.Massage);
            Console.ResetColor();



            Console.WriteLine(" ");

            var result = rentalManager.Add(new Rental {CarID=3, CustomerID=6, RentDate=new DateTime(2020,02,10), ReturnDate= new DateTime(2020,02,13) });
            if (result.Success==true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(result.Massage);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("CarID = "+ "3"+" => "+result.Massage);
                Console.ResetColor();
            }


            Console.ReadLine();
        }
        
    }
}
