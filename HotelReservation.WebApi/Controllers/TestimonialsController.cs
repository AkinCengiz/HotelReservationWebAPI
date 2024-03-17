using HotelReservation.Business.Abstract;
using HotelReservation.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservation.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TestimonialsController : ControllerBase
{
    private readonly ITestimonialService _testimonialService;

    public TestimonialsController(ITestimonialService TestimonialService)
    {
        _testimonialService = TestimonialService;
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = _testimonialService.GetAll();
        return Ok(result);
    }

    [HttpGet("getbyid")]
    public IActionResult GetById(int id)
    {
        var result = _testimonialService.GetById(id);
        return Ok(result);
    }

    [HttpPost("add")]
    public IActionResult Add(Testimonial Testimonial)
    {
        _testimonialService.Add(Testimonial);
        return Ok();
    }

    [HttpPut("update")]
    public IActionResult Update(Testimonial Testimonial)
    {
        _testimonialService.Update(Testimonial);
        return Ok();
    }

    [HttpDelete("delete")]
    public IActionResult Delete(Testimonial Testimonial)
    {
        _testimonialService.Delete(Testimonial);
        return Ok();
    }
}
