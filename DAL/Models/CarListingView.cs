using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class CarListingView
    {
        public string CarDescription { get; set; }
        public string CarYear { get; set; }
        public decimal CarPrice { get; set; }
        public string CarPlateNumber { get; set; }
        public string CarManufacturerName { get; set; }
        public DateTime CarExpireDate { get; set; }
        public string CarType { get; set; }
        public string CarStatus { get; set; }
        public DateTime CarImportDate { get; set; }
        public DateTime CarAssemblyDate { get; set; }
    }
}
