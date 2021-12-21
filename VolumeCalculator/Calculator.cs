using System;

namespace VolumeWebService.VolumeCalculator
{
    public class Calculator
    {
        public VolumeResult CalculateVolumeCylinder(double height, double radius)
        {
            return new VolumeResult()
            {
                //Properties initializer
                Type = "cylinder",
                Height = height,
                Radius = radius,
                Volume = Math.PI * radius * radius * height
            };
        }

        public VolumeResult CalculateVolumeCone(double height, double radius)
        {

            return new VolumeResult()
            {
                Type = "cone",
                Height = height,
                Radius = radius,
                Volume = (Math.PI * radius * radius * height) / 3

            };

        }
    }
}