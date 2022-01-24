using Microsoft.EntityFrameworkCore;

using CAR_RENTAL_SERVICE.Models;


namespace CAR_RENTAL_SERVICE.Infrastructure
{
     public class CarRentalContext : DbContext

    {



        public CarRentalContext(DbContextOptions<CarRentalContext> options) : base(options) {  }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

           

        }

        public DbSet<BillingDetails> Billings { get; set; }
        public DbSet<CustomerDetails> CustomerDetail {get; set;}
        public DbSet<BookingDetails> BookingDetail {get; set;}
        public DbSet<CarCategorys> CarCategory {get; set;}
        public DbSet<Cars> Car {get; set;}
        public DbSet<DiscountDetails> DiscountDetail {get; set;}
        public DbSet<DriverDetails> DriverDetail {get; set;}
        public DbSet<LocationDetails> LocationDetail {get; set;}
        public DbSet<RentalCarInsurances> RentalCarInsurance {get; set;}



    }
}
