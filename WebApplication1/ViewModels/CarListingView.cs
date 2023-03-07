using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.ViewModels
{
    public class CarListingView
    {
        public string CarDescription { get; set; }
        public string CarYear { get; set; }
        public double CarPrice { get; set; }
        public string CarPlateNumber { get; set; }
        public string CarManufacturerName { get; set; }
    }
}