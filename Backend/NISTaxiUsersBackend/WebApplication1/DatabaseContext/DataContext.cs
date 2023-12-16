using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;

namespace WebApplication1.DatabaseContext
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions options) 
			: base(options)
		{

		}

		public DbSet<Driver> Drivers => Set<Driver>();

		public DbSet<Fuel> Fuels => Set<Fuel>();

		public DbSet<FuelCombination> FuelCombinations => Set<FuelCombination>();
		
		public DbSet<TaxiTransaction> Transactions => Set<TaxiTransaction>();

	}
}
