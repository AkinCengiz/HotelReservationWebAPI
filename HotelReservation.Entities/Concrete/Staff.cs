using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservation.Entities.Abstract;

namespace HotelReservation.Entities.Concrete;
public class Staff : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public string SocialMedia1 { get; set; }
    public string SocialMedia2 { get; set; }
    public string SocialMedia3 { get; set; }
}
