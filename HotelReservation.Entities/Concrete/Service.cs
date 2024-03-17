using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservation.Entities.Abstract;

namespace HotelReservation.Entities.Concrete;
public class Service : BaseEntity
{
    public string Icon { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}
