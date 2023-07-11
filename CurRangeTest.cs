using System.Linq;
using TDRange;
using System.Diagnostics;

namespace TDRange
{
    public class CurRangeTest
    {
        public void ValidDuplicateInputs()
        {
            int[] inputArray = { 3, 3, 5, 4, 10, 11, 12 };
            var range = RangeUtils.GenerateSequence(inputArray.Min(), inputArray.Max());
            Debug.Assert(range.Length == 10);
        }
        public void CaptureValuesCount()
        {
            int[] inputArray = { 4, 5 };
            var range = CalcCurrentRange.DetectRange(inputArray);
            Debug.Assert(range[0].Count == 2);
        }
        public void CheckSequenceNumber()
        {
            int[] inputArray = { 3, 3, 5, 4, 10, 11, 12 };
            int[] expArray = { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            var ActualArray = RangeUtils.GenerateSequence(inputArray.Min(), inputArray.Max());
            Debug.Assert(expArray == ActualArray);
        }
        public void CaptureWithCount()
        {
            int[] inputArray = { 3, 3, 5, 4, 10, 11, 12 };
            var range = CalcCurrentRange.DetectRange(inputArray);
            Debug.Assert(range[0].Count == 4);
            Debug.Assert(range[1].Count == 3);
        }
        public void CaptureRange()
        {
            int[] inputArray = { 3, 3, 5, 4, 10, 11, 12 };
            var range = CalcCurrentRange.DetectRange(inputArray);
            string str = (range[0].Min()).ToString() + "-" + (range[0].Max()).ToString();
            Debug.Assert(str == "3-5");
            str = (range[1].Min()).ToString() + "-" + (range[1].Max()).ToString();
            Debug.Assert(str == "10-12");
        }
    }
}
