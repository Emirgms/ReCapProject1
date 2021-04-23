using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car()
                {
                    Id = 1,BrandId=2,ColorId = 1,DailyPrice=70000,ModelYear =2005, Description="Abdullahın eski arabası"
                },
                new Car()
                {
                    Id = 2,BrandId=3,ColorId = 1,DailyPrice=90000,ModelYear =2007, Description="Emirin eski arabası"
                },
                new Car()
                {
                    Id = 3,BrandId=4,ColorId = 2,DailyPrice=150000,ModelYear =2014, Description="Abdullahın yeni arabası"
                }
            };

        }

        public void Add(Car car)
        {
           _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int Id)
        {
            //Veriler içersinde Idsini karşılaştırıp onları çektik.
            Car SearchedId = _cars.Where(c => c.Id == Id).SingleOrDefault();
            return SearchedId;
        }

        public void Update(Car car)
        {
            //Update işlemini verilere göre eşitlik üzerinden yaptık.
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
