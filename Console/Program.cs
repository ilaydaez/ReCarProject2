using Business.Concrete;
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
            //InMemoryDal ınMemoryDal = new InMemoryDal();

            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------ARAÇLAR LİSTESİ-----------------------------");
            Console.ResetColor();
            Console.WriteLine(" ");
            Console.WriteLine(String.Format("{0,-12} | {1,-12}   | {2,-13}   | {3,-14}  | {4,-15}", "BrandName", "ColorName", "DailyPrice", "ModelYear", "Description"));
            Console.WriteLine("---------------------------------------------------------------------------------");
            foreach (var car in carManager.GetAll())
            {

                //Console.WriteLine(String.Format("{0,-12} | {1,-12}   | {2,-13}   | {3,-14}  | {4,-15}", car.BrandName, car.ColorName, car.DailyPrice, car.ModelYear, car.Description));
                Console.WriteLine(String.Format("{0,-12}", car.CarName));
            }

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------ARAÇ EKLENDİ-----------------------------");
            Console.ResetColor();
            Console.WriteLine(" ");
            carManager.Add(new Car
            {
                BrandID = 3,
                BrandName = "BMW",
                ColorID = 1,
                ColorName = "Siyah",
                ModelYear = 2010,
                DailyPrice = 900,
                Description = "Manuel Benzinli"
            });


            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------ARAÇ SİLİNDİ-----------------------------");
            Console.ResetColor();
            Console.WriteLine(" ");
            carManager.Delete(2);


            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------ARAÇ GÜNCELLENDİ-----------------------------");
            Console.ResetColor();
            Console.WriteLine(" ");
            carManager.Update(new Car
            {
                CarID = 4,
                BrandID = 3,
                BrandName = "Renault",
                ColorID = 1,
                ColorName = "kırmızı",
                ModelYear = 2010,
                DailyPrice = 400,
                Description = "Manuel Benzinli"
            });

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------GÜNCEL ARAÇ LİSTESİ-----------------------------");
            Console.ResetColor();
            Console.WriteLine(" ");
            Console.WriteLine("BrandName    |   ColorName    |   DailyPrice    |   ModelYear     |   Description");
            Console.WriteLine("---------------------------------------------------------------------------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(String.Format("{0,-12} | {1,-12}   | {2,-13}   | {3,-14}  | {4,-15}", car.BrandName, car.ColorName, car.DailyPrice, car.ModelYear, car.Description));

            }



            Console.ReadLine();
        }
        
    }
}
