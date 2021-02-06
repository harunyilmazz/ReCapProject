using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Id : "+car.Id+"\nMarka Id : "+car.BrandId+"\nRenk Id : "+car.ColorId+"\nÜretim Yılı : "+car.ModelYear+"\nÜcreti : "+car.DailyPrice+"\nAçıklama : "+car.Description);
                Console.WriteLine("\n-----------------------\n");
            }
        }
    }
}
