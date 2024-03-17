using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservation.Entities.Concrete;

namespace HotelReservation.Business.Abstract;
public interface IRoomService : IGenericService<Room>
{
    Room GetByRoomNumber(string roomNumber);
    List<Room> GetListByBedCount(int count);
    List<Room> GetListByBathCount(int count);
    List<Room> GetListByIsWifi();
}
