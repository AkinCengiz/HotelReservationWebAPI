using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservation.Entities.Abstract;

namespace HotelReservation.Entities.Concrete;
public class Room : BaseEntity
{
    public string RoomNumber { get; set; }
    public string CoverImage { get; set; }
    public decimal Price { get; set; }
    public string Title { get; set; }
    public int BedCount { get; set; }
    public int BathCount { get; set; }
    public bool IsWifi { get; set; }
    public string Description { get; set; }
}
