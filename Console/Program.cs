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

            


            


            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------ARAÇLAR LİSTESİ-----------------------------");
            Console.ResetColor();
            Console.WriteLine(" ");
            Console.WriteLine(String.Format("{0,-12} | {1,-12} | {2,-13} | {3,-13} | {4,-13} | {5,-13} | {6,-15} | {7,-20}| {8,-20} ", "CarID", "CarName", "BrandID","BranName", "ColorID","ColorName", "ModelYear", "DailyPrice", "Description"));
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            foreach (var car in carManager.GetCarDetails())
            {

                Console.WriteLine(String.Format("{0,-12} | {1,-12} | {2,-13} | {3,-13} | {4,-13} | {5,-13} | {6,-15} | {7,-20}| {8,-20} ", car.CarID,
                            car.CarName, car.BrandID, car.BrandName, car.ColorID, car.ColorName, car.ModelYear, car.DailyPrice, car.Description));
            }

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------ARAÇ EKLENDİ-----------------------------");
            Console.ResetColor();
            Console.WriteLine(" ");
            Console.WriteLine(String.Format("{0,-12} | {1,-12} | {2,-13} | {3,-13} | {4,-13} | {5,-13} | {6,-15} ", "CarID", "CarName", "BrandID", "BranName", "ColorID", "ColorName", "ModelYear", "DailyPrice", "Description"));
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            carManager.Add(new Car
            {
                
                CarName = "Ranault",
                BrandID = 3,
                ColorID = 1,
                ModelYear = 2010,
                DailyPrice = 900,
                Description = "Manuel Benzinli"
            });




            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------ARAÇ SİLİNDİ-----------------------------");
            Console.ResetColor();
            Console.WriteLine(" ");
            Console.WriteLine(String.Format("{0,-12} | {1,-12} | {2,-13} | {3,-20} | {4,-15} | {5,-20} | {6,-20}", "CarName", "CarName", "BrandID", "ColorID", "ModelYear", "DailyPrice", "Description"));
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------");
            foreach (var car in carManager.GetByCarID(3027))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(String.Format("{0,-12} | {1,-12} | {2,-13} | {3,-20} | {4,-15} | {5,-20} | {6,-20} ", car.CarID,
                            car.CarName, car.BrandID, car.ColorID, car.ModelYear, car.DailyPrice, car.Description));
                Console.ResetColor();
            }
            carManager.Delete(new Car { CarID = 3027 });


            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------ARAÇ GÜNCELLENDİ-----------------------------");
            Console.ResetColor();
            Console.WriteLine(" ");
            Console.WriteLine(String.Format("{0,-12} | {1,-12} | {2,-13} | {3,-20} | {4,-15} | {5,-20} | {6,-20}", "CarName", "CarName", "BrandID", "ColorID", "ModelYear", "DailyPrice", "Description"));
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------");
            carManager.UpDate(new Car
            {
                CarID = 4,
                CarName="Kia",
                BrandID = 3,
                ColorID = 1,
                ModelYear = 2010,
                DailyPrice = 400,
                Description = "Manuel Benzinli"
            });

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------GÜNCEL ARAÇ LİSTESİ-----------------------------");
            Console.ResetColor();
            Console.WriteLine(" ");
            Console.WriteLine(String.Format("{0,-12} | {1,-12} | {2,-13} | {3,-13} | {4,-13} | {5,-13} | {6,-15} | {7,-20}| {8,-20} ", "CarID", "CarName", "BrandID","BranName", "ColorID","ColorName", "ModelYear", "DailyPrice", "Description"));
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            foreach (var car in carManager.GetCarDetails())
            {

                Console.WriteLine(String.Format("{0,-12} | {1,-12} | {2,-13} | {3,-13} | {4,-13} | {5,-13} | {6,-15} | {7,-20}| {8,-20} ", car.CarID,
                            car.CarName, car.BrandID, car.BrandName, car.ColorID, car.ColorName, car.ModelYear, car.DailyPrice, car.Description));
            }



            Console.ReadLine();
        }
        
    }
}
