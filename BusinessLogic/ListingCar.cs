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

        public Repository<CarDetail> _carRepo = new Repository<CarDetail>();
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

        public List<CarListingView> GetListCarAbc()
        {
            string status;
            var listView = new List<CarListingView>();
            var dataObj = _carRepo.GetAll().Include(x => x.Car)
                .Select(x => new CarListingView
                {
                    //to show only below information at car listing grid
                    CarExpireDate = x.ExpiredDate,
                    CarType = x.CarType,
                    CarImportDate = x.ImportDate,
                    CarAssemblyDate = x.AssemblyDate,
                    CarDescription = x.Car != null ? x.Car.Description : "",
                    CarPlateNumber = x.Car != null ? x.Car.PlateNumber : "",
                    CarPrice = x.Car != null ? x.Car.Price : 0,
                    CarYear = x.Car != null ? x.Car.ProductionYear : "",
                    CarManufacturerName = x.Car.Manufacturer != null ? x.Car.Manufacturer.ManufacturerName : ""
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
                    int dateNow = DateTime.Now.Year;
                    int exDate = val.CarExpireDate.Year;

                    if (val.CarType == "Local")
                    {
                        if ((exDate - dateNow) > 3)
                        {
                            status = "Tidak bisa Dijual";
                        }
                        else
                        {
                            status = "Bisa dijual";
                        }
                    }
                    else
                    {
                        if ((exDate - dateNow) > 5)
                        {
                            status = "Tidak bisa Dijual";
                        }
                        else
                        {
                            status = "Bisa dijual";
                        }
                    }
                    listView.Add(new CarListingView()
                    {
                        CarDescription = val.CarDescription,
                        CarManufacturerName = val.CarManufacturerName,
                        CarPlateNumber = val.CarPlateNumber,
                        CarPrice = val.CarPrice,
                        CarYear = val.CarYear,
                        CarExpireDate = val.CarExpireDate,
                        CarStatus = status,
                        CarAssemblyDate = val.CarAssemblyDate,
                        CarImportDate = val.CarImportDate,
                        CarType = val.CarType
                    });

                }
            }
            return listView.ToList();
        }
    }
}
