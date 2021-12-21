using System.Collections.Generic;
using VolumeWebService.VolumeCalculator;

namespace VolumeWebService.Persistence
{
    public interface IVolumeResultRepository
    {
        public VolumeResult Add(VolumeResult volumeResult);

        public List<VolumeResult> GetAll();

    }
}