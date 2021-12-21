using Microsoft.EntityFrameworkCore;
using VolumeWebService.VolumeCalculator;

namespace VolumeWebService.Persistence
{
    public class CalculatorDbContext:DbContext
    {
        public  DbSet<VolumeResult> VolumeResults { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = calculator.sqlite");
            
        }
        
    }
}