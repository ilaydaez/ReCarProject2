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
            Console.WriteLine("--------------------------Araçlar Listesi-----------------------------");
            Console.ResetColor();
            Console.WriteLine(" ");
            foreach (var car in ınMemoryDal.GetAll())
            {
                Console.WriteLine("BrandName : "+ car.BrandName+ "        "+ 
                    "ColorName : "+ car.ColorName+ "          "+ 
                    "DailyPrice : " + car.DailyPrice+"           " +
                    "ModelYear : "+ car.ModelYear + "           " +
                    "Description : " + car.Description);
                       
            }

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------Araç Eklenedi-----------------------------");
            Console.ResetColor();
            Console.WriteLine(" ");
            ınMemoryDal.Add(new Car {CarID=5, BrandID=3, 
                BrandName="BMW", ColorID=1, ColorName="Siyah", ModelYear=2010, DailyPrice=900, Description="Manuel Benzinli"});


            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------Araç Silindi-----------------------------");
            Console.ResetColor();
            Console.WriteLine(" ");
            ınMemoryDal.Delete(2);


            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------Araç Güncellendi-----------------------------");
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
            Console.WriteLine("--------------------------Güncel Araç Listesi-----------------------------");
            Console.ResetColor();
            Console.WriteLine(" ");
            foreach (var car in ınMemoryDal.GetAll())
            {
                Console.WriteLine("BrandName : " + car.BrandName + "              " +
                    "ColorName : " + car.ColorName + "           " +
                    "DailyPrice : " + car.DailyPrice + "         " +
                    "ModelYear : " + car.ModelYear + "           " +
                    "Description : " + car.Description);

            }



            Console.ReadLine();
        }
        
    }
}
