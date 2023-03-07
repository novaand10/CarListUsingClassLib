using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL.Models
{
    //PLEASE NOTE :
    //THIS IS ROOT CLASS UNABLE TO UPDATE DIRECTLY
    public class Car : BaseEntity
    {
        public string Description { get; set; }
        public string ProductionYear { get; set; }
        public decimal Price { get; set; }
        public string PlateNumber { get; set; }
        public string MachineNumber { get; set; }
        public string OwnershipNumber { get; set; }
        public virtual CarManufacturer Manufacturer { get; set; }

    }
}