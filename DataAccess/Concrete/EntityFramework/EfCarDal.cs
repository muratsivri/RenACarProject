using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,NorthwindContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.Id
                             join d in context.Colors on c.ColorId equals d.Id
                             select new CarDetailDto
                             {
                                 CarName = c.CarName,
                                 ColorName = d.ColorName,
                                 BrandName = b.BrandName,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
   
}
