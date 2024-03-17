using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservation.Entities.Abstract;

namespace HotelReservation.Entities.Concrete;
public class Subscribe : BaseEntity
{
    public string Email { get; set; }
}
