using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservation.DataAccess.Abstract;
using HotelReservation.DataAccess.Concrete.Contexts;
using HotelReservation.Entities.Concrete;

namespace HotelReservation.DataAccess.Concrete.EntityFramework;
public class EfSubscribeDal : EfEntityRepositoryBase<Subscribe,HotelReservationContext>,ISubscribeDal
{
}
