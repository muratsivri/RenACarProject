using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.CarName.Length <= 2)
            {
                return new ErrorResult(Messages.ProductNameInvalid);

            }
            _carDal.Add(car);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult();
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),true,"Ürün listelendi");
        } 

        public IDataResult<Car> GetById(int carId)
        { 
            return _carDal.Get(c => c.Id == carId);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
