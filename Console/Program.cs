using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            InMemoryDal ınMemoryDal = new InMemoryDal();

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------ARAÇLAR LİSTESİ-----------------------------");
            Console.ResetColor();
            Console.WriteLine(" ");
            Console.WriteLine("BrandName    |   ColorName    |   DailyPrice    |   ModelYear     |   Description");
            Console.WriteLine("---------------------------------------------------------------------------------");
            foreach (var car in ınMemoryDal.GetAll())
            {
                
                Console.WriteLine(String.Format("{0,-12} | {1,-12}   | {2,-13}   | {3,-14}  | {4,-15}", car.BrandName, car.ColorName, car.DailyPrice, car.ModelYear, car.Description));

                //Console.WriteLine("BrandName : "+ car.BrandName+ "        "+ 
                //    "ColorName : "+ car.ColorName+ "          "+ 
                //    "DailyPrice : " + car.DailyPrice+"           " +
                //    "ModelYear : "+ car.ModelYear + "           " +
                //    "Description : " + car.Description);

            }

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------ARAÇ EKLENDİ-----------------------------");
            Console.ResetColor();
            Console.WriteLine(" ");
            ınMemoryDal.Add(new Car {CarID=5, BrandID=3, 
                BrandName="BMW", ColorID=1, ColorName="Siyah", ModelYear=2010, DailyPrice=900, Description="Manuel Benzinli"});


            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------ARAÇ SİLİNDİ-----------------------------");
            Console.ResetColor();
            Console.WriteLine(" ");
            ınMemoryDal.Delete(2);


            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------ARAÇ GÜNCELLENDİ-----------------------------");
            Console.ResetColor();
            Console.WriteLine(" ");
            ınMemoryDal.Update(new Car
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
            foreach (var car in ınMemoryDal.GetAll())
            {
                Console.WriteLine(String.Format("{0,-12} | {1,-12}   | {2,-13}   | {3,-14}  | {4,-15}", car.BrandName, car.ColorName, car.DailyPrice, car.ModelYear, car.Description));

                //Console.WriteLine("BrandName : " + car.BrandName + "              " +
                //    "ColorName : " + car.ColorName + "           " +
                //    "DailyPrice : " + car.DailyPrice + "         " +
                //    "ModelYear : " + car.ModelYear + "           " +
                //    "Description : " + car.Description);

            }



            Console.ReadLine();
        }
        
    }
}
