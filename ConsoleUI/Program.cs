using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();
            foreach (var car in inMemoryCarDal.GetAll())
            {
                 Console.WriteLine(car.Description);
            }
           
        }
    }
}
