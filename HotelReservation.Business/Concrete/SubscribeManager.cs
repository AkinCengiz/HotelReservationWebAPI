using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservation.Business.Abstract;
using HotelReservation.DataAccess.Abstract;
using HotelReservation.Entities.Concrete;

namespace HotelReservation.Business.Concrete;
public class SubscribeManager : ISubscribeService
{
    private readonly ISubscribeDal _subscribeDal;
    public void Add(Subscribe entity)
    {
        _subscribeDal.Add(entity);
    }

    public void Update(Subscribe entity)
    {
        _subscribeDal.Update(entity);
    }

    public void Delete(Subscribe entity)
    {
        _subscribeDal.Delete(entity);
    }

    public List<Subscribe> GetAll()
    {
        return _subscribeDal.GetList();
    }

    public List<Subscribe> GetByActive()
    {
        return _subscribeDal.GetList(s => s.IsActive == true);
    }

    public Subscribe GetById(int id)
    {
        return _subscribeDal.Get(s => s.Id == id);
    }
}
