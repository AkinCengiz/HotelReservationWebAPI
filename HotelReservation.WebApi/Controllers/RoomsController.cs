using HotelReservation.Business.Abstract;
using HotelReservation.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservation.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class RoomsController : ControllerBase
{
    private readonly IRoomService _roomService;

    public RoomsController(IRoomService RoomService)
    {
        _roomService = RoomService;
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = _roomService.GetAll();
        return Ok(result);
    }

    [HttpGet("getbyid")]
    public IActionResult GetById(int id)
    {
        var result = _roomService.GetById(id);
        return Ok(result);
    }

    [HttpPost("add")]
    public IActionResult Add(Room Room)
    {
        _roomService.Add(Room);
        return Ok();
    }

    [HttpPut("update")]
    public IActionResult Update(Room Room)
    {
        _roomService.Update(Room);
        return Ok();
    }

    [HttpDelete("delete")]
    public IActionResult Delete(Room Room)
    {
        _roomService.Delete(Room);
        return Ok();
    }
}
