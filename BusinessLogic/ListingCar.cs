using BusinessLogic.Interface;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ListingCar : IListingCar
    {
        private readonly DBContext _dbContext;

        public Repository<Car> _carRepository = new Repository<Car>();
        public ListingCar(DBContext dBContext)
        {
            _dbContext = dBContext;

        }
        public List<CarListingView> GetListCar()
        {
        
        var listView = new List<CarListingView>();
            var dataObj = _carRepository.GetAll().Include(x => x.Manufacturer)
                .Select(x => new CarListingView
                {
                    //to show only below information at car listing grid
                    CarDescription = x.Description,
                    CarPlateNumber = x.PlateNumber,
                    CarPrice = x.Price,
                    CarYear = x.ProductionYear,
                    CarManufacturerName = x.Manufacturer != null ? x.Manufacturer.ManufacturerName : ""
                }).ToList();
            if (dataObj == null)
            {
                listView.Add(new CarListingView()
                {
                    CarDescription = "-",
                    CarManufacturerName = "-",
                    CarPlateNumber = "-",
                    CarPrice = 0,
                    CarYear = "-"
                });
            }
            else
            {
                foreach (var val in dataObj)
                {
                    listView.Add(new CarListingView()
                    {
                        CarDescription = val.CarDescription,
                        CarManufacturerName = val.CarManufacturerName,
                        CarPlateNumber = val.CarPlateNumber,
                        CarPrice = val.CarPrice,
                        CarYear = val.CarYear
                    });
                }
            }
            return listView.ToList();
        }
    }
}
