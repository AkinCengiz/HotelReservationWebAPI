using HotelReservation.Business.Abstract;
using HotelReservation.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservation.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class SubscribesController : ControllerBase
{
    private readonly ISubscribeService _subscribeService;

    public SubscribesController(ISubscribeService subscribeService)
    {
        _subscribeService = subscribeService;
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = _subscribeService.GetAll();
        return Ok(result);
    }

    [HttpGet("getbyid")]
    public IActionResult GetById(int id)
    {
        var result = _subscribeService.GetById(id);
        return Ok(result);
    }

    [HttpPost("add")]
    public IActionResult Add(Subscribe subscribe)
    {
        _subscribeService.Add(subscribe);
        return Ok();
    }

    [HttpPut("update")]
    public IActionResult Update(Subscribe subscribe)
    {
        _subscribeService.Update(subscribe);
        return Ok();
    }

    [HttpDelete("delete")]
    public IActionResult Delete(Subscribe subscribe)
    {
        _subscribeService.Delete(subscribe);
        return Ok();
    }
}
