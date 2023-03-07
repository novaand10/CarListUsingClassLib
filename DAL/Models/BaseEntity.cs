using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL.Models
{
    //PLEASE NOTE :
    //THIS IS ROOT CLASS UNABLE TO UPDATE DIRECTLY
    public class BaseEntity
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        //public string CarType { get; set; }
        //public DateTime ExpiredDate { get; set; }
        //public DateTime ImportDate { get; set; }
        //public DateTime AssemblyDate { get; set; }
    }
}