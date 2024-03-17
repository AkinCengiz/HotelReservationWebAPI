using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservation.Business.Abstract;
using HotelReservation.DataAccess.Abstract;
using HotelReservation.Entities.Concrete;

namespace HotelReservation.Business.Concrete;
public class StaffManager : IStaffService
{
    private readonly IStaffDal _staffDal;

    public StaffManager(IStaffDal staffDal)
    {
        _staffDal = staffDal;
    }

    public void Add(Staff entity)
    {
        _staffDal.Add(entity);
    }

    public void Update(Staff entity)
    {
        _staffDal.Update(entity);
    }

    public void Delete(Staff entity)
    {
        _staffDal.Delete(entity);
    }

    public List<Staff> GetAll()
    {
        return _staffDal.GetList();
    }

    public List<Staff> GetByActive()
    {
        return _staffDal.GetList(s => s.IsActive == true);
    }

    public Staff GetById(int id)
    {
        return _staffDal.Get(s => s.Id == id);
    }
}
