using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservation.Business.Abstract;
using HotelReservation.DataAccess.Abstract;
using HotelReservation.Entities.Concrete;

namespace HotelReservation.Business.Concrete;
public class RoomManager : IRoomService
{
    private readonly IRoomDal _roomDal;

    public RoomManager(IRoomDal roomDal)
    {
        _roomDal = roomDal;
    }

    public void Add(Room entity)
    {
        _roomDal.Add(entity);
    }

    public void Update(Room entity)
    {
        _roomDal.Update(entity);
    }

    public void Delete(Room entity)
    {
        _roomDal.Delete(entity);
    }

    public List<Room> GetAll()
    {
        return _roomDal.GetList();
    }

    public List<Room> GetByActive()
    {
        return _roomDal.GetList(r => r.IsActive == true);
    }

    public Room GetById(int id)
    {
        return _roomDal.Get(r => r.Id == id);
    }

    public Room GetByRoomNumber(string roomNumber)
    {
        return _roomDal.Get(r => r.RoomNumber == roomNumber);
    }

    public List<Room> GetListByBedCount(int count)
    {
        return _roomDal.GetList(r => r.BedCount == count);
    }

    public List<Room> GetListByBathCount(int count)
    {
        return _roomDal.GetList(r => r.BathCount == count);
    }

    public List<Room> GetListByIsWifi()
    {
        return _roomDal.GetList(r => r.IsWifi == true);
    }
}
