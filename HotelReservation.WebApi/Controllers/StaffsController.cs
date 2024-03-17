using HotelReservation.Business.Abstract;
using HotelReservation.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservation.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class StaffsController : ControllerBase
{
    private readonly IStaffService _staffService;

    public StaffsController(IStaffService staffService)
    {
        _staffService = staffService;
    }

    [HttpGet("getall")]
    public IActionResult StaffList()
    {
        var result = _staffService.GetAll();
        return Ok(result);
    }

    [HttpPost("add")]
    public IActionResult AddStaff(Staff staff)
    {
        _staffService.Add(staff);
        return Ok();
    }

    [HttpDelete("delete")]
    public IActionResult DeleteStaff(Staff staff)
    {
        _staffService.Delete(staff);
        return Ok();
    }

    [HttpPut("update")]
    public IActionResult UpdateStaff(Staff staff)
    {
        _staffService.Update(staff);
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult GetStaff(int id)
    {
        _staffService.GetById(id);
        return Ok();
    }
}
