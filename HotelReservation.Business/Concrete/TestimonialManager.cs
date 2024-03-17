using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservation.Business.Abstract;
using HotelReservation.DataAccess.Abstract;
using HotelReservation.Entities.Concrete;

namespace HotelReservation.Business.Concrete;
public class TestimonialManager : ITestimonialService
{
    private readonly ITestimonialDal _testimonialDal;
    public void Add(Testimonial entity)
    {
        _testimonialDal.Add(entity);
    }

    public void Update(Testimonial entity)
    {
        _testimonialDal.Update(entity);
    }

    public void Delete(Testimonial entity)
    {
        _testimonialDal.Delete(entity);
    }

    public List<Testimonial> GetAll()
    {
        return _testimonialDal.GetList();
    }

    public List<Testimonial> GetByActive()
    {
        return _testimonialDal.GetList(t => t.IsActive == true);
    }

    public Testimonial GetById(int id)
    {
        return _testimonialDal.Get(t => t.Id == id);
    }
}
