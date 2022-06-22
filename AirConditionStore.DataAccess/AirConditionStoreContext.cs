using AirConditionStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AirConditionStore.DataAccess
{
    public class AirConditionStoreContext : DbContext
    {
        public AirConditionStoreContext()
        {
        }

        public AirConditionStoreContext(DbContextOptions<AirConditionStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AirCondition> AirConditions { get; set; }
        public virtual DbSet<AirConditionType> AirConditionTypes { get; set; }
        public virtual DbSet<Capability>  Capabilities { get; set; }
        public virtual DbSet<Compressor> Compressors { get; set; }
        public virtual DbSet<ControlType> ControlTypes { get; set; }
        public virtual DbSet<IndoorUnitInstallationType> InstallationTypes { get; set; }
        public virtual DbSet<OperatingMode> OperatingModes { get; set; }
        public virtual DbSet<OperationNegativeTemperature> AirConditionsTemperatures { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ProducingCountry> Countries { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserInformation> UsersInformation { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost,1433; Database=AirConditionStore; User=sa; Password=HrefKiuN2493Jndhu23;");
            }
        }

    }
}