using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace be_dozun_tasks.Data
{
    public class DztasksDbContextFactory : IDesignTimeDbContextFactory<DztasksDbContext>
    {
        public DztasksDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configurationRoot.GetConnectionString("DefaultConnection");

            var optionBuilder = new DbContextOptionsBuilder<DztasksDbContext>();

            optionBuilder.UseSqlServer(connectionString);

            return new DztasksDbContext(optionBuilder.Options);
        }
    }
}
