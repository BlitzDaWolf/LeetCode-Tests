class TwoSumClass
{
    public int[] TwoSum(int[] numbers, int target)
    {
        for (int i = 0; i < numbers.Length-1; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] == target) return new int[] { numbers[i], numbers[j] };
            }
        }
        return null;
    }
}