namespace StatOperations
{
    public class StatsMean
    {
        public static dynamic Mean(dynamic values)
        {
            var sum = operations.Addition.Sum(values);
            var valueCount = values.Length;
            var result = operations.Division.Quot(sum, valueCount);
            return result;
        }


    }
}