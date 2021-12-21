using System.Collections.Generic;
using System.Linq;
using VolumeWebService.VolumeCalculator;

namespace VolumeWebService.Persistence
{
    public class DbVolumeRepository:IVolumeResultRepository
    {
        private CalculatorDbContext _calculatorDbContext;

        public DbVolumeRepository(CalculatorDbContext calculatorDbContext)
        {
            _calculatorDbContext = calculatorDbContext;
        }
        public VolumeResult Add(VolumeResult volumeResult)
        {

           _calculatorDbContext.VolumeResults.Add(volumeResult);
           _calculatorDbContext.SaveChanges();
           return volumeResult;


        }

        public List<VolumeResult> GetAll()
        {

           return _calculatorDbContext.VolumeResults.ToList();
        }
    }
}