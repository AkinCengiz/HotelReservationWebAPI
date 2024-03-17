using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservation.Business.Abstract;
using HotelReservation.DataAccess.Abstract;
using HotelReservation.Entities.Concrete;

namespace HotelReservation.Business.Concrete;
public class ServiceManager : IServiceService
{
    private readonly IServiceDal _serviceDal;

    public ServiceManager(IServiceDal serviceDal)
    {
        _serviceDal = serviceDal;
    }

    public void Add(Service entity)
    {
        _serviceDal.Add(entity);
    }

    public void Update(Service entity)
    {
        _serviceDal.Update(entity);
    }

    public void Delete(Service entity)
    {
        _serviceDal.Delete(entity);
    }

    public List<Service> GetAll()
    {
        return _serviceDal.GetList();
    }

    public List<Service> GetByActive()
    {
        return _serviceDal.GetList(s => s.IsActive == true);
    }

    public Service GetById(int id)
    {
        return _serviceDal.Get(s => s.Id == id);
    }
}
