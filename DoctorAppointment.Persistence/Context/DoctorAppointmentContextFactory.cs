using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DoctorAppointment.Persistence.Context
{
    public class DoctorAppointmentContextFactory : IDesignTimeDbContextFactory<DoctorAppointmentContext>
    {
        public DoctorAppointmentContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<DoctorAppointmentContext> optionsBuilder = new();

            optionsBuilder.UseSqlServer(connectionString: "Server=sqlserver,1433;Database=DoctorAppointmentDB;User Id=sa;Password=DA@123123;TrustServerCertificate=True;");

            return new DoctorAppointmentContext(optionsBuilder.Options);
        }
    }
}
