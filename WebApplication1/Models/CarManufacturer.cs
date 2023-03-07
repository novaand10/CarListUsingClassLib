using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    //PLEASE NOTE :
    //THIS IS ROOT CLASS UNABLE TO UPDATE DIRECTLY
    public class CarManufacturer : BaseEntity
    {
        public string ManufacturerRegistrationNumber { get; set; }
        public string ManufacturerName { get; set; }
        public string ManufacturerAddress { get; set; }
    }
}