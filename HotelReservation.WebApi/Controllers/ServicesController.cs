using HotelReservation.Business.Abstract;
using HotelReservation.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservation.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ServicesController : ControllerBase
{

    private readonly IServiceService _serviceService;

    public ServicesController(IServiceService ServiceService)
    {
        _serviceService = ServiceService;
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = _serviceService.GetAll();
        return Ok(result);
    }

    [HttpGet("getbyid")]
    public IActionResult GetById(int id)
    {
        var result = _serviceService.GetById(id);
        return Ok(result);
    }

    [HttpPost("add")]
    public IActionResult Add(Service Service)
    {
        _serviceService.Add(Service);
        return Ok();
    }

    [HttpPut("update")]
    public IActionResult Update(Service Service)
    {
        _serviceService.Update(Service);
        return Ok();
    }

    [HttpDelete("delete")]
    public IActionResult Delete(Service Service)
    {
        _serviceService.Delete(Service);
        return Ok();
    }
}
