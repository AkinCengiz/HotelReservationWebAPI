
using HotelReservation.Business.Abstract;
using HotelReservation.Business.Concrete;
using HotelReservation.DataAccess.Abstract;
using HotelReservation.DataAccess.Concrete.Contexts;
using HotelReservation.DataAccess.Concrete.EntityFramework;

namespace HotelReservation.WebApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddDbContext<HotelReservationContext>();
        builder.Services.AddScoped<IRoomService, RoomManager>();
        builder.Services.AddScoped<IRoomDal, EfRoomDal>();
        builder.Services.AddScoped<IStaffService, StaffManager>();
        builder.Services.AddScoped<IStaffDal, EfStaffDal>();
        builder.Services.AddScoped<IServiceService, ServiceManager>();
        builder.Services.AddScoped<IServiceDal, EfServiceDal>();
        builder.Services.AddScoped<ISubscribeService, SubscribeManager>();
        builder.Services.AddScoped<ISubscribeDal, EfSubscribeDal>();
        builder.Services.AddScoped<ITestimonialService, TestimonialManager>();
        builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
