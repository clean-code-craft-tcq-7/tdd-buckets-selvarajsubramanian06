using System;
using System.Collections.Generic;

namespace TDRange
{
    public class AnalogToDigital
    {
        public List<ConverterModel> ConvertToAmp(decimal[] input)
        {
            List<ConverterModel> convertedData = new List<ConverterModel>();
            foreach (var bitValue in input)
            {
                ConverterModel values = new ConverterModel();
                decimal amps = 10 * bitValue / 4094;
                if (amps > 10)
                    values.Error = 1;
                else
                    values.AmpValue = Math.Round(amps);
                convertedData.Add(values);
            }
            return convertedData;
        }
    }
}
