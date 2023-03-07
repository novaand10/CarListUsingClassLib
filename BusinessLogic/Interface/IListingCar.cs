using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace BusinessLogic.Interface
{
    public interface IListingCar
    {
        List<CarListingView> GetListCar();
    }
}
