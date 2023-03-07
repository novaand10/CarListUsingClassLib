using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class CarDetail : BaseEntity
    {
        public string CarType { get; set; }
        public DateTime ExpiredDate { get; set; }
        public DateTime ImportDate { get; set; }
        public DateTime AssemblyDate { get; set; }
        public virtual Car Car { get; set; }
    }
}
