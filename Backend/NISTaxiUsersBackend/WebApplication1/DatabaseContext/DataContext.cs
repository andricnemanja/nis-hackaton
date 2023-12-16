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

		public DbSet<Driver> Drivers { get; set; }

		public DbSet<Fuel> Fuels { get; set; }

		public DbSet<FuelCombination> FuelCombinations {  get; set; }
		
		public DbSet<TaxiTransaction> Transactions {  get; set; }


	}
}
