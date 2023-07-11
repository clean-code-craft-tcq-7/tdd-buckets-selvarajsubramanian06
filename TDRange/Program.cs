using System;
using System.Collections.Generic;
using System.Text;

namespace TDRange
{
    public class Program
    {
        static void Main(string[] args)
        {
            CurRangeTest currentRangeTest = new CurRangeTest();
            currentRangeTest.ValidDuplicateInputs();
            currentRangeTest.CaptureValuesCount();
            currentRangeTest.CheckSequenceNumber();
            currentRangeTest.CaptureWithCount();
            currentRangeTest.CaptureRange();

            A2DTest a2DConvertorTest = new A2DTest();
            a2DConvertorTest.CreateA2DObject();
            a2DConvertorTest.ValidateErrorInput();
            a2DConvertorTest.ValidateInput();
            a2DConvertorTest.ValidateInvalidInputs();
            a2DConvertorTest.DetectRangeIgnoringErrorValue();
        }
    }
}
