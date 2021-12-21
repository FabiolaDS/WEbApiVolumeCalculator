using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VolumeWebService.Persistence;
using VolumeWebService.VolumeCalculator;

namespace VolumeWebService.Controllers
{
    [ApiController]
    [Route("/calculate")]
    public class CalculatorController : ControllerBase

    {
        private IVolumeResultRepository _repository;

        private Calculator _calculator;

        public CalculatorController(Calculator calculator,IVolumeResultRepository repo)
        {
            this._calculator = calculator;
            this._repository = repo;
        }

        [HttpGet("cylinder")]
        
        public VolumeResult GetVolumeCylinder([FromQuery] double height, [FromQuery] double radius)
        {
            
             VolumeResult result =_calculator.CalculateVolumeCylinder(height, radius);
             _repository.Add(result);
             return result;
        }
        [HttpGet("results")]
        public List <VolumeResult> GetAllResultList()
        {
            return _repository.GetAll();
        }

        [HttpGet("cone")]
        public VolumeResult GetVolumeCone([FromQuery] double height, [FromQuery] double radius)
        {
            VolumeResult r= _calculator.CalculateVolumeCone(height, radius);
            _repository.Add(r);
            return r;
        }
    }
}