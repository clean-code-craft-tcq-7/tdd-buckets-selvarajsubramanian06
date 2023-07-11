using TDRange;
using System.Diagnostics;
using System.Linq;

namespace TDRange
{
    internal class A2DTest
    {
        public void CreateA2DObject()
        {
            AnalogToDigital name = new AnalogToDigital();
            Debug.Assert(name != null);
        }
        public void ValidateErrorInput()
        {
            decimal[] inputArr = { 4095 };
            AnalogToDigital sensorValue = new AnalogToDigital();
            var range = sensorValue.ConvertToAmp(inputArr);
            Debug.Assert(range[0].Error == 1);
        }
        public void ValidateInput()
        {
            decimal[] inputArr = { 1500 };
            AnalogToDigital sensorValue = new AnalogToDigital();
            var range = sensorValue.ConvertToAmp(inputArr);
            Debug.Assert(range[0].AmpValue == 4);
        }
        public void ValidateInvalidInputs()
        {
            decimal[] inputArr = { 1146, 4095, 4094, 1614 };
            AnalogToDigital sensorValue = new AnalogToDigital();
            var range = sensorValue.ConvertToAmp(inputArr);
            int[] arrs = RangeUtils.convertToArray(range);
            Debug.Assert(arrs == new[] { 3, 10, 4 } );
        }
        public void DetectRangeIgnoringErrorValue()
        {
            decimal[] inputArr = { 1146, 4095, 4094, 1614, 3880 };
            AnalogToDigital sensorValue = new AnalogToDigital();
            var bitConvertedValue = sensorValue.ConvertToAmp(inputArr);
            int[] arrs = RangeUtils.convertToArray(bitConvertedValue);
            var ranges = CalcCurrentRange.DetectRange(arrs);
            string str = (ranges[0].Min()).ToString() + "-" + (ranges[0].Max()).ToString();
            Debug.Assert(str == "3-4");
            str = (ranges[1].Min()).ToString() + "-" + (ranges[1].Max()).ToString();
            Debug.Assert(str == "9-10");
        }
    }
}
